﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.ComponentModel;
using System.Security.Permissions;
using Microsoft.Win32;

namespace UVA_Arena.Structures
{
    [StructLayout(LayoutKind.Sequential)]
    public class CatagoryList
    { 
        public int count { get; set; }
        public string name { get; set; }
        public object tag { get; set; } 
        public CatagoryList() { }
    }
    
    [StructLayout(LayoutKind.Sequential)]
    public class ProblemInfo
    {
        public enum Status
        {
            Unavailable,
            Normal,
            Special_Judge,
            Accepted,
            Tried
        };

        /// <summary>Problem ID</summary>
        public long pid { get; set; }
        /// <summary>Problem Number
        public long pnum { get; set; }
        /// <summary>Problem Title
        public string ptitle { get; set; }
        /// <summary>Number of Distinct Accepted User (DACU)
        public long dacu { get; set; }
        /// <summary>Best Runtime of an Accepted Submission
        public long run { get; set; }
        /// <summary>Best Memory used of an Accepted Submission
        public long mem { get; set; }
        /// <summary>Number of No Verdict Given (can be ignored)
        public long nver { get; set; }
        /// <summary>Number of Submission Error
        public long sube { get; set; }
        /// <summary>Number of Can't be Judged
        public long cbj { get; set; }
        /// <summary>Number of In Queue
        public long inq { get; set; }
        /// <summary>Number of Compilation Error
        public long ce { get; set; }
        /// <summary>Number of Restricted Function
        public long resf { get; set; }
        /// <summary>Number of Runtime Error
        public long re { get; set; }
        /// <summary>Number of Output Limit Exceeded
        public long ole { get; set; }
        /// <summary>Number of Time Limit Exceeded
        public long tle { get; set; }
        /// <summary>Number of Memory Limit Exceeded
        public long mle { get; set; }
        /// <summary>Number of Wrong Answer
        public long wa { get; set; }
        /// <summary>Number of Presentation Error
        public long pe { get; set; }
        /// <summary>Number of Accepted
        public long ac { get; set; }
        //Problem Run-Time Limit (milliseconds)
        public long rtl { get; set; }
        //Problem Status (0 = unavailable, 1 = normal, 2 = special judge)
        public long stat { get; set; }
         
        //formatted special values 
        public Status status { get; set; }
        public int volume { get; set; }
        public long total { get; set; }
        public int level { get; set; }
        public string star { get; set; }
        public List<string> tags = new List<string>();

        public void parse(List<string> data)
        {
            //[36,100,"The 3n + 1 problem",61026,0,1000000000,0,6473,0,0,93803,0,50329,49,48954,5209,215870,3957,157711,3000,1]

            Type t = typeof(ProblemInfo);
            PropertyInfo[] pcol = t.GetProperties();
            for (int i = 0; i < data.Count; ++i)
            {
                object val = null;
                if (pcol[i].Name == "ptitle") val = data[i];
                else val = long.Parse(data[i]);
                pcol[i].SetValue(this, val, null);
            }

            volume = (int)(pnum / 100);
            if (run >= 1000000000) run = -1;
            if (mem >= 1000000000) mem = -1;
            
            total = ac + wa + cbj + ce + mle + tle + ole + nver + pe + re + resf + sube;
            
            if (stat == 0) status = Status.Unavailable;
            else if (stat == 1) status = Status.Normal;
            else status = Status.Special_Judge;

            star = "";
            double urank = (total == 0) ? 0 : (double)ac / total;
            if (urank < 0.35) star += '*';
            if (urank <= 0.15) star += '*';

            tags = RegistryAccess.GetTags(pnum);
        }

        public ProblemInfo() { }
        public ProblemInfo(List<string> data) { parse(data); }
    }
}