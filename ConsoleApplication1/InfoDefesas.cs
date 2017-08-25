﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
   public class InfoDefesas
    {
        public class Root
        {
            
            public long? ret_code { get; set; }
            public long? ts_val { get; set; }
            public string tzone { get; set; }
            public long? tvalue { get; set; }
            public long? tvaluelocal { get; set; }

            public long? defense_wizard_id { get; set; }
            public long? guild_id { get; set; }

            public  List<List<GuildWarDefenseUnitList>> guildwar_defense_unit_list { get; set; }

            //public GuildwarRankingInfo guildwar_ranking_info { get; set; }
            //public GuildwarParticipationInfo guildwar_participation_info { get; set; }
            //public GuildwarReserve guildwar_reserve { get; set; }
            //public string command { get; set; }
            //public GuildwarRankingStat guildwar_ranking_stat { get; set; }
            //public List<GuildMemberDefenseList> guild_member_defense_list { get; set; }
            //public List<GuildwarMemberList> guildwar_member_list { get; set; }
        }
    }

    public class GuildWarDefenseUnitList
    {
        public long? pos_id { get; set; }

        public UnitInfo unit_info { get; set;}

    }
    public class UnitInfo
    {
        public long? unit_id { get; set; }
        public long? wizard_id { get; set; }
        public long? unit_master_id { get; set; }
                
    }
}
