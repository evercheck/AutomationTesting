﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Selen.Controls
{
    public class Textbox:BaseControl
    {

        public Textbox() : base() { }
        public Textbox(By by):base(by){ }
        public Textbox(string xPath) : base(xPath) { }

    }
}
