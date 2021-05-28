using System.Collections.Generic;

namespace Factory.Models
{
  public class Factory
  {
    public Factory()
    {
      this.JoinEntities = new HashSet<EngineerMachine>();
    }

    public int EngineerId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime HireDate { get; set; }
    public int SkillLevel { get; set; }

    public virtual ICollection<EngineerItem> JoinEntities { get; set; }
  }
}