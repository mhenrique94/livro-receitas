using IntroAPI.Controllers;
using IntroMVC.Models;
using Microsoft.EntityFrameworkCore;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Intro_Teste
{
    public class CategoriasControllerTest
    {
        private readonly Mock<DbSet<Categoria>> _mockSet;
        private readonly Mock<Contexto> _mockContext;
        private readonly Categoria _categoria;

        public CategoriasControllerTest()
        {
            _mockSet = new Mock<DbSet<Categoria>>();
            _mockContext = new Mock<Contexto>();
            _categoria = new Categoria { id = 1, Descricao = "Teste Categoria" };
        }

        [Fact]
        public async Task Get_Categoria()
        {
            var service = new CategoriaController(_mockContext.Object);

            await service.GetCategoria(id: 1);

            _mockSet.Verify(expression: m => m.FindAsync(params keyValues: 1),
                Times.Once());

        }
    }

 }
