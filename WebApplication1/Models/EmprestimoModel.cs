namespace WebApplication1.Models
{
    //reprentará uma coluna no BD
    public class EmprestimoModel
    {
     //Campos da tablea BD

     public int Id { get; set; }
     public string Recebedor { get; set; }
     public string Fornecedor { get; set; }
     
     public string LivroEmprestado { get; set; }
     public DateTime DataEmprestimo { get; set; } = DateTime.Now;



 


    }
}
