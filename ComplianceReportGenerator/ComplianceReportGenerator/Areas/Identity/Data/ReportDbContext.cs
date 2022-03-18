using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComplianceReportGenerator.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ComplianceReportGenerator.Data
{
    public class ReportDbContext : IdentityDbContext<IdentityUser>
    {
        public DbSet<Test> Tests { get; set; }
        public DbSet<Test2> Tests2 { get; set; }
        public DbSet<Test3> Tests3 { get; set; }
        public DbSet<Citation> Citations { get; set; }
        public ReportDbContext(DbContextOptions<ReportDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Citation>().HasData(
                new Citation
                    {
                        Id = 1,
                        Type = "NRS",
                        Chapter = "678A",
                        Section = "085",
                        Summary = "“Cannabis” defined.",
                        Body = "“Cannabis” has the meaning ascribed to the term “marijuana” in NRS 453.096",
                        Recommendation = "Several product labels were observed with the word “marijuana,” rather than the required word “cannabis.”  The CCB has been clear since their takeover in July 2020 that all use of the word marijuana must be phased out, definitely by July 2021. Please refer to the attached picture and communicate with vendors to correct their labels and packaging as soon as possible.",
                        LowPenalty = 10000,
                        HighPenalty = 90000,
                    },
                

                new Citation
                    {
                        Id = 2,
                        Type = "NCCR",
                        Chapter = "9",
                        Section = "085",
                        Summary = "Surfaces of equipment and utensils: Cleanliness.",
                        Body = "Each cannabis product manufacturing facility shall ensure that: surfaces of equipment and utensils that have direct contact with cannabis products are clean to sight and touch; 2.The surfaces of cooking equipment and pans that have direct contact with cannabis products are kept free of encrusted grease deposits and other soil accumulations; and 3.The surfaces of equipment that do not have direct contact with cannabis products are kept free of an accumulation of dust, dirt, residue and other debris.",
                        Recommendation = "We discussed numerous items directly in touch with cannabis. Please clean and maintain the interior of the freeze dryer in the hash room, and the mixing bowls in the chocolate room. We discussed a number of solutions to keep those surfaces cleaned and maintained. Please see pictures.",
                        LowPenalty = 5000,
                        HighPenalty = 80000,
                    },
               


                new Citation
                    {
                        Id = 3,
                        Type = "NCCR",
                        Chapter = "10",
                        Section = "005",
                        Summary = "Cannabis establishment: Requirements for building used to manufacture, process, package or hold cannabis.",
                        Body = "1.	Each cannabis establishment shall ensure that any building used to manufacture, process, package or hold cannabis or cannabis products: (a) Is of suitable size, construction and location to facilitate cleaning, maintenance and proper operations;[…] 2.Each cannabis establishment shall ensure that: (a)The flow of components, product containers, closures, labels, in-process materials and cannabis and cannabis products through any building used to manufacture, process, package or hold cannabis or cannabis products is designed to prevent contamination; (b)The operations of the cannabis establishment are performed within specifically defined areas of adequate size; (c)All items are stored at least 6 inches(15 cm) off the floor;[…] ",
                        Recommendation = "In the extraction room, we observed a large container, a cooler and a bucket on the floor. These are minor issues but CCB has recently been citing facilities for not having all items in storage 6 inches above the floor. Please find another location for these items if at all possible.",
                        LowPenalty = 5000,
                        HighPenalty = 80000,
                    },
               

                new Citation
                    {
                        Id = 4,
                        Type = "NCCR",
                        Chapter = "10",
                        Section = "035",
                        Summary = "Cannabis cultivation facility, cannabis product manufacturing facility and cannabis sales facility: Establishment of and adherence to written procedures for components, product containers and closures. ",
                        Body = "Each cannabis cultivation facility, cannabis product manufacturing facility and cannabis sales facility shall ensure that: 1.It has written procedures describing in sufficient detail the receipt, identification, storage, handling, sampling, testing and approval or rejection of components, product containers and closures and that it follows those procedures.A copy of these procedures shall be provided promptly to the Board or Board Agents upon request; 2.Components, product containers and closures are at all times handled and stored in a manner so as to prevent contamination;[…] ",
                        Recommendation = "During the walkthrough, we found most areas clean and organized. We did find some ethanol spray bottles without labels. Please label all spray bottles and containers that are no longer in the original container.",
                        LowPenalty = 10000,
                        HighPenalty = 90000,
                    },
             

                new Citation
                    {
                        Id = 5,
                        Type = "NCCR",
                        Chapter = "6",
                        Section = "080",
                        Summary = "Inventory control system; authorized sources for acquisition of cannabis and cannabis products; duties of establishment if loss incurred; maintenance and availability of documentation.",
                        Body = "[…] 5.Each cannabis establishment, except a cannabis independent testing laboratory, shall establish and implement an inventory control system that documents: […] (9) The disposal of cannabis that is not usable cannabis, including: (I)A description of and reason for the cannabis being disposed of, including, if applicable, the number of failed or other unusable cannabis plants; (II)The date of disposal; (III)Confirmation that the cannabis was rendered unusable before disposal; (IV)The method of disposal; and (V) The name and the number of the cannabis establishment agent registration card of the cannabis establishment agent responsible for the disposal. ",
                        Recommendation = "As trained while onsite, for your waste logs, please specify the disposal method. Maybe a check box? It’s either kitty litter or bokashi, but it cannot be both (reference photo 9).",
                        LowPenalty = 10000,
                        HighPenalty = 90000,
                     }
                 );
        }
    }
}
