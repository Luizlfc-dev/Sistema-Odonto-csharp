namespace Controllers.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class banco : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Consulta",
                c => new
                    {
                        ID_CONSULTA = c.Int(nullable: false, identity: true),
                        ID_PACIENTE = c.Int(nullable: false),
                        ID_DENTISTA = c.Int(nullable: false),
                        DATA_CONSULTA = c.DateTime(nullable: false),
                        HORA_MARCADA = c.DateTime(nullable: false),
                        HORA_INICIO = c.DateTime(nullable: false),
                        HORA_FIM = c.DateTime(nullable: false),
                        DentistaId = c.Int(nullable: false),
                        PacienteId = c.Int(nullable: false),
                        OBSERVACAO_CONSULTA = c.String(nullable: false, maxLength: 500),
                        STATUS_CONSULTA = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.ID_CONSULTA)
                .ForeignKey("dbo.Dentista", t => t.DentistaId, cascadeDelete: true)
                .ForeignKey("dbo.Paciente", t => t.PacienteId, cascadeDelete: true)
                .Index(t => t.DentistaId)
                .Index(t => t.PacienteId);
            
            CreateTable(
                "dbo.Dentista",
                c => new
                    {
                        ID_DENTITSTA = c.Int(nullable: false, identity: true),
                        NOME_DENTITSTA = c.String(nullable: false, maxLength: 100),
                        CRO = c.String(nullable: false, maxLength: 15),
                        ESPECIALIDADE_DENTISTA = c.String(nullable: false, maxLength: 50),
                        TELEFONE_DENTISTA = c.Long(nullable: false),
                        EMAIL_DENTISTA = c.String(nullable: false, maxLength: 100),
                        CELULAR_DENTISTA = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.ID_DENTITSTA);
            
            CreateTable(
                "dbo.Paciente",
                c => new
                    {
                        ID_PACIENTE = c.Int(nullable: false, identity: true),
                        NOME_PACIENTE = c.String(nullable: false, maxLength: 100),
                        DATA_NASCIMENTO_PACIENTE = c.DateTime(nullable: false),
                        TELEFONE_PACIENTE = c.Long(nullable: false),
                        CELULAR_PACIENTE = c.Long(nullable: false),
                        EMAIL_PACIENTE = c.String(nullable: false, maxLength: 100),
                        COMPLEMENTO_ENDERECO_PACIENTE = c.String(nullable: false, maxLength: 50),
                        ENDERECO_PACIENTE = c.String(nullable: false, maxLength: 14),
                        CEP_PACIENTE = c.String(nullable: false, maxLength: 10),
                        SEXO_PACIENTE = c.String(nullable: false, maxLength: 10),
                    })
                .PrimaryKey(t => t.ID_PACIENTE);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Consulta", "PacienteId", "dbo.Paciente");
            DropForeignKey("dbo.Consulta", "DentistaId", "dbo.Dentista");
            DropIndex("dbo.Consulta", new[] { "PacienteId" });
            DropIndex("dbo.Consulta", new[] { "DentistaId" });
            DropTable("dbo.Paciente");
            DropTable("dbo.Dentista");
            DropTable("dbo.Consulta");
        }
    }
}
