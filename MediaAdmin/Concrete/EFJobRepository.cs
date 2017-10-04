using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediaAdmin.Abstract;
using MediaAdmin.MediaEntity;

namespace MediaAdmin.Concrete
{
    public class EFJobRepository : IEFJobRepository
    {
        private EFDbMediaTranslations context = new EFDbMediaTranslations();

        public IEnumerable<Job> Jobs
        {
            get
            {
                return context.Jobs;
            }
        }

        public void SaveJob(Job job)
        {
            if (job.JobID == 0)
            {
                context.Jobs.Add(job);
            }
            else
            {
                Job dbEntry = context.Jobs.Find(job.JobID);
                {
                    if (dbEntry != null)
                    {
                        dbEntry.CustomerID = job.CustomerID;
                        dbEntry.CustomerName = job.CustomerName;
                        dbEntry.StartDate = job.StartDate;
                        dbEntry.EndDate = job.EndDate;
                        dbEntry.SourceLanguage = job.SourceLanguage;
                        dbEntry.TargetLanguage1 = job.TargetLanguage1;
                        dbEntry.TargetLanguage2 = job.TargetLanguage2;
                        dbEntry.TargetLanguage3 = job.TargetLanguage3;
                        dbEntry.TargetLanguage4 = job.TargetLanguage4;
                        dbEntry.TargetLanguage5 = job.TargetLanguage5;
                        dbEntry.TargetLanguage6 = job.TargetLanguage6;
                        dbEntry.TargetLanguage7 = job.TargetLanguage7;
                        dbEntry.Payment = job.Payment;
                        dbEntry.Value = job.Value;
                        dbEntry.Status = job.Status;
                        dbEntry.Added = job.Added;
                    }
                }
                context.SaveChanges();
            }
        }
    }
}
