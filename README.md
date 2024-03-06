# The Seven Deadly Sins Farmbot

Program made to play and clear any content of the Korean and Japanese versions of the game The Seven Deadly Sins: Grand Cross in seconds.

This repository is a sample of the entire farmbot. Running it as is only logs into an account and does nothing else.

I created and made public the whole farmbot in November 2022. It shut it down later because the risk of an account getting banned was too high.

I'm not at ease with explaining things and English isn't my native language so sorry if I don't make sense, but you can always ask questions on discord (alexisc_) I'll be happy to answer.

## Build

Get the dlls ProudNetClientPlugin.dll and ProudDotNetClientUnity.dll from the game.

- ProudNetClientPlugin.dll is a native dll and manages the communication with the game server, copy it in the /dll folder and the output directory.

- ProudDotNetClientUnity.dll is a managed dll and is the "bridge" between our program and ProudNetClientPlugin, copy it in the /dll folder and add is as a reference to the projects 7dsgcFarmbot and Marshaler.


## How it works

1. [Game Client](#game-client)
2. [Auth & Login](#auth-login)
3. [Database](#database)
4. [Localization](#localization)


## Game Client

The code in /7dsgcFarmbot/GameClient manages the game client.
The code inside the Marshaler project is also very important.

The game client is responsible for all the communications with the game servers and does the requests to play the game (start a quest, finish a quest, win a stage, summon, upgrade a unit...).

The game uses a third party software called [Proud Net](https://proudnet.com/) from Nettention and the remote method invocation (RMI) mechanism. There are about 1000 different RMI.

The code can connect to two servers: the game and the relay server. The relay server is only used to play co-op and PVP and the game server everything else, both server work the exact same way so I'll just explain the game server.

The ClientBase class contains the NetClient object from ProudDotNetClientUnity we don't need to understand how it works internally, just that it's the object we will use to connect, disconnect and set callbacks, and a guid called protocol version that will be compared with the one in the game server during the connection, if it doesn't match the connection will be declined.

GameClient is a dependency of ClientBase, it contains the callback method for the connection attempt result and all the methods to send requests to GameProxy that will enqueue the request for later.

GamePacketHandler will initialize and store the Stubs with their callbacks splitted in GameClient/PacketHandler/.

PacketManager is a bit complex, it's a singleton that contains the GameClient object and that will process the requests enqueued by GameProxy, it has 2 threads running in the background : 

- UpdateThread that let ProudNet call all the callbacks every 10 milliseconds.
- ProcessMessageThread that will wait for a request to be enqueued, send it and wait for a response.

It was my first time dealing with multi threading and honestly I think I did it very badly, since the responses are received in callbacks by another thread I found it difficult to wait for the response and continue the execution afterwards, what I did was use AutoResetEvent to lock the main thread after enqueuing and resume it when the response is received, but that means only the main thread can send requests, sending a request in a callback will stuck the program forever.
There is definitely a better way to write this class, and even if I did give up updating the program, I'd love to know how to improve this class if you have ideas.

The Marshaler project contains the classes MarshalerRead and MarshalerWrite used to serialize and deserialize objects from received RMI responses.
MarshalerWrite will be used by SevenDSGameC2S.Proxy, a class that contains a method for each RMI request, to serialize the objects into a Nettention.Proud.Message and send the message to GameProxy.
MarshalerRead will be used by SevenDSGameS2C*/Stub.cs to deserialize a Message into objects and call the appropriate callback.
The code from the Marshaler project is big and redundant because it was generated with a script. It takes some time to compile and isn't meant to be changed, by making another project we don't have to compile that code every time.


## Auth & Login

The authentication process is done with the game API (7dsgcFarmbot/API/) using the sync code and password.

First we get the configuration file from the cdn, this file contains information about the API server and game server.

To authenticate, we generate a random player id (pid) and do a request with it to obtain encryption keys linked to that pid.
We then encrypt the account password with the encryption keys we just got, and do a second request with the random pid, the sync code and the encrypted password, this will give us the real account pid and an access token.

The login process is done with the game server, we request CG_RequestNetmarbleAuth with the pid and access token from the API, the response will give us account info: if the account is banned, the account usn which is a unique id given during the account creation and two coordinates. These coordinates represent a pixel on the image /7dsgcFarmbot/fx_vt.png, we need to get the argb color of that pixel and request CG_RequestLogin with the account usn and color to finally be logged in.


## Database

The code in /7dsgcFarmbot/DataTable manages the database.

The database is composed of many binary files zipped in /7dsgcFarmbot/DataTable/Tables.zip.

Each file contains a serialized collection of objects of the same type, representing one kind of data (items, quests, summon banners, units stats and many many more).


## Localization

The code in /7dsgcFarmbot/Localization manages the localization.

The game texts are stored in a SQLite database. Each language has its own database but the structure remains the same for all of them.

The database has only one table called TRANSLATION, this table has 3 columns : id, si and translated.

- id is a text, the game source code uses constant strings to access the data.
- si is an int, it is used by the database (much smaller to store than strings).
- translated is a xored text, it is the localized string.

| id | si | translated |
| - | - | - |
| DB_hero_name_100100 | 25909 | Meliodas |
| DB_hero_name_102900 | 25424 | Twigo |
| DB_hero_group_name_1135003 | 25837 | "Infinity" Great Mage Merlin |

