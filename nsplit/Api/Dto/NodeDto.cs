﻿using System.Runtime.Serialization;

namespace nsplit.Api.Dto
{
    [DataContract]
    public class NodeDto
    {
        //      // Expected format of the node (there are no required fields)
        //{
        //  id          : "string" // will be autogenerated if omitted
        //  text        : "string" // node text
        //  icon        : "string" // string for custom
        //  state       : {
        //    opened    : boolean  // is the node open
        //    disabled  : boolean  // is the node disabled
        //    selected  : boolean  // is the node selected
        //  },
        //  children    : []  // array of strings or objects
        //  li_attr     : {}  // attributes for the generated LI node
        //  a_attr      : {}  // attributes for the generated A node
        //}

        [DataMember(Name = "id")]
        public int Id { get; set; }

        [DataMember(Name = "text")]
        public string Name { get; set; }

        [IgnoreDataMember]
        public bool IsLeaf { get; set; }

        [DataMember(Name = "children")]
        public bool CanHaveChildren
        {
            get
            {
                return !IsLeaf;
            }
        }

        [DataMember(Name = "icon")]
        public string Icon
        {
            get
            {
                return IsLeaf ? "/css/c.png" : "/css/n.png";
            }
        }
    }
}