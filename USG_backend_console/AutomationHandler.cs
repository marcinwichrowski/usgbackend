﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Input;
using System.Net;
using System.Net.Sockets;

namespace USG_backend_console
{
    class AutomationHandler
    {
        AutomationElement testWindow;

        public AutomationHandler()
        {
            StartAutomation();
            hideBtnPress();
            //GlobalSettings.paramConn = new TCPconnection(GlobalSettings.clientSocket.Client.RemoteEndPoint.ToString().Split(':')[0], 12000);
            //GlobalSettings.paramConn.connect();
        }

        public void HandleStringCommand(string command)
        {
            switch (command.ToLower())
            {
                case "frze":          
                    Console.WriteLine("Pressing freeze button");
                    freezeBtnPress();
                    break;
                case "gaup":
                    Console.WriteLine("Pressing gain up button");
                    gainUpBtnPress();
                    break;
                case "gadn":
                    Console.WriteLine("Pressing gain down button");
                    gainDownBtnPress();
                    break;
                case "arup":
                    Console.WriteLine("Pressing area up button");
                    areaUpBtnPress();
                    break;
                case "ardn":
                    Console.WriteLine("Pressing area down button");
                    areaDownBtnPress();
                    break;
                case "hide":
                    Console.WriteLine("Pressing hide button");
                    hideBtnPress();
                    break;
                case "save":
                    Console.WriteLine("Pressing save button");
                    saveBtnPress();
                    break;
                case "8bgr":
                    GlobalSettings.writer.WriteLine("Changing palette to 8-bit greyscale");
                    paletteChange("8-bit linear grayscale");
                    break;
                case "ggai":
                    GlobalSettings.writer.WriteLine(getGain());
                    Console.WriteLine("Sent gain value");
                    break;
                case "gtxf":
                    GlobalSettings.writer.WriteLine(getTXfrequency());
                    Console.WriteLine("Sent tx frequency");
                    break;
                case "gtxt":
                    GlobalSettings.writer.WriteLine(getTXtype());
                    Console.WriteLine("Sent tx type");
                    break;
                case "gimr":
                    GlobalSettings.writer.WriteLine(getImagingRange());
                    Console.WriteLine("Sent imaging range value");
                    break;
                case "gfps":
                    GlobalSettings.writer.WriteLine(getFramerate());
                    Console.WriteLine("Sent framerate");
                    break;
                default:
                    Console.WriteLine("default switch statement, nothing happened");
                    break;
            }
        }

        private void StartAutomation()
        {
            AutomationElement desktopObject = AutomationElement.RootElement;
            System.Windows.Automation.Condition testWindowNameCondition = new PropertyCondition(AutomationElement.NameProperty, "uScan2 GUI");
            this.testWindow = desktopObject.FindFirst(TreeScope.Children, testWindowNameCondition);
        }

        private void freezeBtnPress()
        {
            System.Windows.Automation.Condition textConditionOne = new PropertyCondition(AutomationElement.AutomationIdProperty, "Freeze_Btn");
            AutomationElement textOne = testWindow.FindFirst(TreeScope.Descendants, textConditionOne);
            InvokePattern valuetextOne = textOne.GetCurrentPattern(InvokePattern.Pattern) as InvokePattern;
            valuetextOne.Invoke();
        }

        private void gainUpBtnPress()
        {
            System.Windows.Automation.Condition textConditionOne = new PropertyCondition(AutomationElement.AutomationIdProperty, "gain_up");
            AutomationElement textOne = testWindow.FindFirst(TreeScope.Descendants, textConditionOne);
            InvokePattern valuetextOne = textOne.GetCurrentPattern(InvokePattern.Pattern) as InvokePattern;
            valuetextOne.Invoke();
        }

        private void gainDownBtnPress()
        {
            System.Windows.Automation.Condition textConditionOne = new PropertyCondition(AutomationElement.AutomationIdProperty, "gain_down");
            AutomationElement textOne = testWindow.FindFirst(TreeScope.Descendants, textConditionOne);
            InvokePattern valuetextOne = textOne.GetCurrentPattern(InvokePattern.Pattern) as InvokePattern;
            valuetextOne.Invoke();
        }

        private void areaUpBtnPress()
        {
            System.Windows.Automation.Condition textConditionOne = new PropertyCondition(AutomationElement.AutomationIdProperty, "area_up");
            AutomationElement textOne = testWindow.FindFirst(TreeScope.Descendants, textConditionOne);
            InvokePattern valuetextOne = textOne.GetCurrentPattern(InvokePattern.Pattern) as InvokePattern;
            valuetextOne.Invoke();
        }

        private void areaDownBtnPress()
        {
            System.Windows.Automation.Condition textConditionOne = new PropertyCondition(AutomationElement.AutomationIdProperty, "area_down");
            AutomationElement textOne = testWindow.FindFirst(TreeScope.Descendants, textConditionOne);
            InvokePattern valuetextOne = textOne.GetCurrentPattern(InvokePattern.Pattern) as InvokePattern;
            valuetextOne.Invoke();
        }

        private void hideBtnPress()
        {
            System.Windows.Automation.Condition textConditionOne = new PropertyCondition(AutomationElement.AutomationIdProperty, "Hide_Btn");
            AutomationElement textOne = testWindow.FindFirst(TreeScope.Descendants, textConditionOne);
            InvokePattern valuetextOne = textOne.GetCurrentPattern(InvokePattern.Pattern) as InvokePattern;
            valuetextOne.Invoke();
        }

        private void saveBtnPress()
        {
            System.Windows.Automation.Condition textConditionOne = new PropertyCondition(AutomationElement.AutomationIdProperty, "Save_Btn");
            AutomationElement textOne = testWindow.FindFirst(TreeScope.Descendants, textConditionOne);
            InvokePattern valuetextOne = textOne.GetCurrentPattern(InvokePattern.Pattern) as InvokePattern;
            valuetextOne.Invoke();
        }

        private string getGain()
        {
            System.Windows.Automation.Condition textConditionOne = new PropertyCondition(AutomationElement.AutomationIdProperty, "gain_disp");
            AutomationElement lblOne = testWindow.FindFirst(TreeScope.Descendants, textConditionOne);
            return lblOne.Current.Name;
        }

        private string getTXfrequency()
        {
            System.Windows.Automation.Condition textConditionOne = new PropertyCondition(AutomationElement.AutomationIdProperty, "TXFreqLabel");
            AutomationElement lblOne = testWindow.FindFirst(TreeScope.Descendants, textConditionOne);
            return lblOne.Current.Name;
        }

        private string getTXtype()
        {
            System.Windows.Automation.Condition textConditionOne = new PropertyCondition(AutomationElement.AutomationIdProperty, "TXTypeLabel");
            AutomationElement lblOne = testWindow.FindFirst(TreeScope.Descendants, textConditionOne);
            return lblOne.Current.Name;
        }

        private string getImagingRange()
        {
            System.Windows.Automation.Condition textConditionOne = new PropertyCondition(AutomationElement.AutomationIdProperty, "area_disp");
            AutomationElement lblOne = testWindow.FindFirst(TreeScope.Descendants, textConditionOne);
            return lblOne.Current.Name;
        }

        private string getFramerate()
        {
            System.Windows.Automation.Condition textConditionOne = new PropertyCondition(AutomationElement.AutomationIdProperty, "FramerateLabel");
            AutomationElement lblOne = testWindow.FindFirst(TreeScope.Descendants, textConditionOne);
            return lblOne.Current.Name;
        }

        private void paletteChange(String name)
        {
            try
            {
                System.Windows.Automation.Condition textConditionOne = new PropertyCondition(AutomationElement.AutomationIdProperty, "Palettecombo");
                AutomationElement textOne = testWindow.FindFirst(TreeScope.Descendants, textConditionOne);
                ExpandCollapsePattern valuetextOne = textOne.GetCurrentPattern(ExpandCollapsePattern.Pattern) as ExpandCollapsePattern;
                valuetextOne.Expand();
                AutomationElement listItem = textOne.FindFirst(TreeScope.Subtree, new PropertyCondition(AutomationElement.NameProperty, name));
                AutomationPattern automationPatternFromElement = GetSpecifiedPattern(listItem, "SelectionItemPatternIdentifiers.Pattern");
                SelectionItemPattern selectionItemPattern = listItem.GetCurrentPattern(automationPatternFromElement) as SelectionItemPattern;
                selectionItemPattern.Select();
                valuetextOne.Collapse();
            }
            catch (Exception ex) 
            {
                Console.WriteLine("Couldn't change palette to " + name);
            }
            
        }

        private void signalChange(String name)
        {
            System.Windows.Automation.Condition textConditionOne = new PropertyCondition(AutomationElement.AutomationIdProperty, "TXcombo");
            AutomationElement textOne = testWindow.FindFirst(TreeScope.Descendants, textConditionOne);
            ExpandCollapsePattern valuetextOne = textOne.GetCurrentPattern(ExpandCollapsePattern.Pattern) as ExpandCollapsePattern;
            valuetextOne.Expand();
            AutomationElement listItem = textOne.FindFirst(TreeScope.Subtree, new PropertyCondition(AutomationElement.NameProperty, name));
            AutomationPattern automationPatternFromElement = GetSpecifiedPattern(listItem, "SelectionItemPatternIdentifiers.Pattern");
            SelectionItemPattern selectionItemPattern = listItem.GetCurrentPattern(automationPatternFromElement) as SelectionItemPattern;
            selectionItemPattern.Select();
            valuetextOne.Collapse();
        }

        private static AutomationPattern GetSpecifiedPattern(AutomationElement element, string patternName)
        {
            AutomationPattern[] supportedPattern = element.GetSupportedPatterns();

            foreach (AutomationPattern pattern in supportedPattern)
            {
                if (pattern.ProgrammaticName == patternName)
                    return pattern;
            }

            return null;
        }

    }
}
