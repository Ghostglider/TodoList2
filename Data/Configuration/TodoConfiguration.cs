using Data.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;


namespace Data
{
	internal class TodoConfiguration : EntityTypeConfiguration<Todo>
	{
		public TodoConfiguration()
		{
			HasKey(k => k.Id);

			//Properties
			Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

			// Requiered
			Property(p => p.TodoLable).IsRequired();
			Property(p => p.TodoDescription).IsRequired();
			Property(p => p.Traite).IsRequired();

			// Mapping
			ToTable("Todo");
			Property(p => p.Id).HasColumnName("ID");
			Property(p => p.TodoLable).HasColumnName("TodoLabel");
			Property(p => p.TodoDescription).HasColumnName("TodoDescription");
			Property(p => p.Traite).HasColumnName("Traite");

		}
	}
}