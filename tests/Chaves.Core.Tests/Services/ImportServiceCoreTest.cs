using Chaves.Core.Services;
using Chaves.Core.ViewModel;
using Chaves.Core.ViewModel.Enums;
using FluentAssertions;
using Xunit;

namespace Chaves.Core.Tests.Services
{
    [Trait(nameof(ImportServiceCore), "")]
    public class ImportServiceCoreTest
    {
        [Fact(DisplayName = "Deve Retonar Tela de Falha")]
        public void DeveRetornarTelaDeFalha()
        {

            var result = ImportServiceCore.Import("");

            result.Should().NotBeNull();

            result.Should().BeEquivalentTo(new ImportDetailsViewModelCore { Msg = ImporServiceSatus.Fail, Count = 0 });

        }

    }
}
