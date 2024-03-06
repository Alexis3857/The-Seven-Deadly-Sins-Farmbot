public class DataTableCryptographer  // Some db store xored value in fields and returns the decrypted value in the getter (ie: DBConfigGameRow)
{
    public static int CRPTO_BYTE_COUNT = 16;

    protected virtual uint XOROperand  // Each db that encrypts value has its own XOROperand (protected override uint XOROperand)
    {
        get
        {
            return 68113U;
        }
    }

    public byte[] EncryptByte(byte value)
    {
        return ToXORByteArray(new byte[]
        {
            value
        });
    }

    public byte[] EncryptInt16(short value)
    {
        return ToXORByteArray(BitConverter.GetBytes(value));
    }

    public byte[] EncryptInt32(int value)
    {
        return ToXORByteArray(BitConverter.GetBytes(value));
    }

    public byte[] EncryptInt64(long value)
    {
        return ToXORByteArray(BitConverter.GetBytes(value));
    }

    public byte[] EncryptFloat(float value)
    {
        return ToXORByteArray(BitConverter.GetBytes(value));
    }

    public byte[] EncryptDouble(double value)
    {
        return ToXORByteArray(BitConverter.GetBytes(value));
    }

    public char[] EncryptString(string value)
    {
        return ToXORCharArray(value);
    }

    public byte DecryptByte(byte[] datas)
    {
        return ToXORByteArray(datas)[0];
    }

    public short DecryptInt16(byte[] datas)
    {
        return BitConverter.ToInt16(ToXORByteArray(datas), 0);
    }

    public int DecryptInt32(byte[] datas)
    {
        return BitConverter.ToInt32(ToXORByteArray(datas), 0);
    }

    public long DecryptInt64(byte[] datas)
    {
        return BitConverter.ToInt64(ToXORByteArray(datas), 0);
    }

    public float DecryptFloat(byte[] datas)
    {
        return BitConverter.ToSingle(ToXORByteArray(datas), 0);
    }

    public double DecryptDouble(byte[] datas)
    {
        return BitConverter.ToDouble(ToXORByteArray(datas), 0);
    }

    public string DecryptString(char[] datas)
    {
        return ToXORString(datas);
    }

    private int ToXORInt32(int value)
    {
        return (int)((long)value ^ (long)((ulong)XOROperand));
    }

    private long ToXORInt64(long value)
    {
        return value ^ (long)((ulong)XOROperand);
    }

    private byte[] ToXORByteArray(byte[] arrayValue)
    {
        if (arrayValue == null || arrayValue.Length == 0)
        {
            return new byte[0];
        }
        byte[] array = new byte[arrayValue.Length];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = (byte)((uint)arrayValue[i] ^ XOROperand);
        }
        return array;
    }

    private char[] ToXORCharArray(string value)
    {
        if (string.IsNullOrEmpty(value))
        {
            return new char[0];
        }
        char[] array = value.ToCharArray();
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = (char)((uint)array[i] ^ XOROperand);
        }
        return array;
    }

    private string ToXORString(char[] arrayCharValue)
    {
        if (arrayCharValue == null || arrayCharValue.Length == 0)
        {
            return "";
        }
        string text = "";
        for (int i = 0; i < arrayCharValue.Length; i++)
        {
            text += ((char)((uint)arrayCharValue[i] ^ XOROperand)).ToString();
        }
        return text;
    }
}
