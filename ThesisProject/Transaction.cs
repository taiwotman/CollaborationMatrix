/***
 Author: Taiwo O. Adetiloye, 2012
*****/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ThesisProject
{
    class Transaction
    {
        private List<TestCase> testCases;
        private char[] signs;
        private string binary;
        public List<int> factorSN { get; private set; }
        public List<int> factorCC { get; private set; } 

        public List<TestCase> generateTestCases(TestCase unsignedTestCaseData)
        {
            testCases = new List<TestCase>();
            factorSN = new List<int>();
            factorCC = new List<int>();

            for (int i = 0; i < 64; i++)
            {
                binary = Convert.ToString(i, 2);
                binary = (binary.Length < 6) ? binary.PadRight(6, '0') : binary;

                signs = nextSign(binary);
                TestCase tc = new TestCase();

                tc.Business11.S = Convert.ToInt32(String.Format("{0}{1}", signs[0], unsignedTestCaseData.Business11.S));
                tc.Business11.E = Convert.ToInt32(String.Format("{0}{1}", signs[1], unsignedTestCaseData.Business11.E));
                tc.Business11.En = Convert.ToInt32(String.Format("{0}{1}", signs[2], unsignedTestCaseData.Business11.En));

                tc.Customer12.S = Convert.ToInt32(String.Format("{0}{1}", signs[3], unsignedTestCaseData.Customer12.S));
                tc.Customer12.E = Convert.ToInt32(String.Format("{0}{1}", signs[4], unsignedTestCaseData.Customer12.E));
                tc.Customer12.En = Convert.ToInt32(String.Format("{0}{1}", signs[5], unsignedTestCaseData.Customer12.En));

                tc.Customer21.S = Convert.ToInt32(String.Format("{0}{1}", signs[0], unsignedTestCaseData.Customer21.S));
                tc.Customer21.E = Convert.ToInt32(String.Format("{0}{1}", signs[1], unsignedTestCaseData.Customer21.E));
                tc.Customer21.En = Convert.ToInt32(String.Format("{0}{1}", signs[2], unsignedTestCaseData.Customer21.En));

                tc.Customer22.S = Convert.ToInt32(String.Format("{0}{1}", signs[3], unsignedTestCaseData.Customer22.S));
                tc.Customer22.E = Convert.ToInt32(String.Format("{0}{1}", signs[4], unsignedTestCaseData.Customer22.E));
                tc.Customer22.En = Convert.ToInt32(String.Format("{0}{1}", signs[5], unsignedTestCaseData.Customer22.En));

                tc.output();

                testCases.Add(tc);

                factorSN.Add(tc.TestCaseWeightSN.Value);
                factorCC.Add(tc.TestCaseWeightCC.Value);
            }
            return testCases;
        }

        private char[] nextSign(String binary)
        {
            char[] signs = new char[6];

            for (int j = 0; j < binary.Length; j++)
            {
                if (binary[j] == '1')
                {
                    signs[j] = '+';
                }
                else
                {
                    signs[j] = '-';
                }
            }

            return signs;
        }
    }
}
