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
            return $"Type: {this.Type}\n Chapter: {this.Chapter} Section: {this.Section} Summary: {this.Summary} Body: {this.Body} Recommendation: {this.Recommendation} Low Penalty: {this.LowPenalty} High Penalty: {this.HighPenalty}";
        }
    }
}
