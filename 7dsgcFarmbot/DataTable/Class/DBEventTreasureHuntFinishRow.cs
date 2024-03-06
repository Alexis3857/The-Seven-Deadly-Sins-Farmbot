﻿public class DBEventTreasureHuntFinishRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int SubIndex
    {
        get
        {
            return sub_index;
        }
    }

    public int RewardOrder
    {
        get
        {
            return reward_order;
        }
    }

    public int RewardGroup
    {
        get
        {
            return reward_group;
        }
    }

    public int RewardItemId
    {
        get
        {
            return reward_item_id;
        }
    }

    public int RewardItemCount
    {
        get
        {
            return reward_item_count;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        sub_index = reader.ReadInt32();
        reward_order = reader.ReadInt32();
        reward_group = reader.ReadInt32();
        reward_item_id = reader.ReadInt32();
        reward_item_count = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int sub_index;

    private int reward_order;

    private int reward_group;

    private int reward_item_id;

    private int reward_item_count;
}
