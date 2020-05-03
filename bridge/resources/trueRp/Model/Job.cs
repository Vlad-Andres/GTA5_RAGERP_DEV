using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace trueRp.Model{
    [Table("Job")]
    public class Job{

        public Job(){
            this.Name = Types.Jobs.none;
        }

        public Job(int jobID, Types.Jobs job){
            this.JobID = jobID;
            this.Name = job;
        }

        [Key]
        public int JobID { get; set; }
        public Types.Jobs Name { get; set; }
    }
}