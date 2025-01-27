﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MouseAdventure.Models
{
    // ISpeak Interface, used by Mouse class
    interface ISpeak
    {
        List<string> Messages { get; set; }
        string Speak();
    }
}
