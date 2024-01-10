using System.ComponentModel.DataAnnotations;

namespace GallowsGame.Models.Entity;

public class BaseEntity
{
    public long Id { get; set; }
    public string Name { get; set; }
}