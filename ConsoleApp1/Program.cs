using System;
using System.Collections.Generic;
using Bayantu.Evos.Services.Match.Domain.Aggregates.PsaBusinessNegotiationAggregate;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {


            Test2();

            var x = 1;

        }

        private static List<int> Test2() 
        {
            var roleFlags = (OpenFunctionalVerificationEnum)73728;

            var propertys = typeof(OpenFunctionalVerificationEnum);
            var fields = propertys.GetFields();
            List<int> funcVerficationTags = new List<int>();
            foreach (var field in fields)
            {
                var name = field.Name;
                try
                {
                    OpenFunctionalVerificationEnum openFunctionalVerificationEnum = (OpenFunctionalVerificationEnum)Enum.Parse(typeof(OpenFunctionalVerificationEnum), name, true);

                    if (roleFlags.HasFlag(openFunctionalVerificationEnum))
                    {
                        funcVerficationTags.Add((int)openFunctionalVerificationEnum);
                    }
                }
                catch (Exception e)
                {
                }
            }

            return funcVerficationTags;
        }

        private static void Test1() 
        {
            var propertys = typeof(NegotiationStatusType);

            var fields = propertys.GetFields();

            List<NegotiationStatus> status = new List<NegotiationStatus>();

            foreach (var field in fields)
            {
                NegotiationStatus negotiationStatus = new NegotiationStatus()
                {
                    Value = field.Name,
                    Label = NegotiationStatusType.FromValue(field.Name).CodeName
                };

                status.Add(negotiationStatus);
            }
        }
    }

    public class NegotiationStatus
    {
        public string Value { get; set; }
        public string Label { get; set; }
    }
}
