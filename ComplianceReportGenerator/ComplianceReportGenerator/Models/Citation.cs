using System;
namespace ComplianceReportGenerator.Models
{
    public class Citation
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Chapter { get; set; }
        public string Section { get; set; }
        public string Summary { get; set; }
        public string Body { get; set; }
        public string Recommendation { get; set; }
        public int LowPenalty { get; set; }
        public int HighPenalty { get; set; }


        public Citation()
        {

        }

        public override string ToString()
        {
            
            return $"Type: {Type}\n Chapter: {Chapter} Section: {Section} Summary: {Summary} Body: {Body} Recommendation: {Recommendation} Low Penalty: {LowPenalty} High Penalty: {HighPenalty}";
        }
    }
}
