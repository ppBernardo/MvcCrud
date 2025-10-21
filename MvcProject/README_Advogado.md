# CRUD de Advogados - MVC 5
## 📚 Projeto para Estudo e Demonstração

Este projeto implementa um CRUD completo para gerenciamento de advogados seguindo o padrão MVC 5 e as especificações da documentação. **Ideal para estudos e demonstrações** de conceitos de desenvolvimento web com ASP.NET MVC.

## Funcionalidades Implementadas

### ✅ Campos Obrigatórios
- **Nome do Advogado**: Campo de texto com validação
- **Senioridade**: Combo com opções (Júnior, Pleno, Sênior)
- **Endereço Segmentado**:
  - Logradouro (obrigatório)
  - Bairro (obrigatório)
  - Estado (combo com todos os estados brasileiros)
  - CEP (com máscara 00000-000)
  - Número (apenas números)
  - Complemento (opcional)

### ✅ Diferenciais Implementados
- **Máscaras**: CEP com formatação automática
- **Enums**: Senioridade implementada como enum
- **Validações**: ValidationMessage para cada campo
- **JavaScript**: Scripts customizados seguindo o padrão da documentação

## Estrutura do Projeto

### Modelos
- `Models/Senioridade.cs` - Enum para senioridade
- `Models/Advogado.cs` - Classe de domínio
- `Models/AdvogadoViewModel.cs` - ViewModel para as views
- `Models/Interface/IAdvogadoRepositorio.cs` - Interface do repositório
- `Models/Implementacao/AdvogadoRepositorio.cs` - Implementação do repositório
- `Models/Implementacao/MySqlRepositorio.cs` - Classe base para repositórios

### Controller
- `Controllers/AdvogadoController.cs` - Controller com todas as operações CRUD

### Views
- `Views/Advogado/Index.cshtml` - Lista de advogados
- `Views/Advogado/Create.cshtml` - Criar novo advogado
- `Views/Advogado/Edit.cshtml` - Editar advogado
- `Views/Advogado/Details.cshtml` - Detalhes do advogado
- `Views/Advogado/Delete.cshtml` - Excluir advogado

### Scripts
- `Scripts/app/AdvogadoViewModel.js` - JavaScript com máscaras e validações

## 🎯 **Características para Estudo**

### ✅ **Dados em Memória - Ideal para Aprendizado**
- **Sem configuração de banco** - Foco no aprendizado do MVC
- **Dados de exemplo incluídos** - Pronto para testar imediatamente
- **Reset automático** - Dados voltam ao estado inicial a cada execução

### **📊 Dados de Exemplo para Demonstração**
O sistema já vem com 3 advogados de exemplo pré-cadastrados:
- **João Silva** (Sênior) - São Paulo - *Demonstra senioridade sênior*
- **Maria Santos** (Júnior) - São Paulo - *Demonstra senioridade júnior*
- **Pedro Oliveira** (Pleno) - São Paulo - *Demonstra senioridade pleno*

### **🔄 Comportamento de Estudo**
- **Dados temporários** - Perfeito para experimentar sem medo de "quebrar"
- **Reinício limpo** - Cada execução começa do zero
- **Sem persistência** - Foco no aprendizado dos conceitos MVC

## Padrões Seguidos

### Nomenclatura de Métodos
- `IncluirAdvogado()` - Para inclusão
- `AtualizarAdvogado()` - Para edição
- `ExcluirAdvogado()` - Para exclusão
- `ListarAdvogados()` - Para listagem
- `ObterAdvogado()` - Para obter dados específicos
- `VerificarAdvogadoExiste()` - Para verificação

### Parâmetros
- `pObjAdvogado` - Para objetos de domínio
- `pIntId` - Para IDs inteiros
- `pStrNome` - Para strings

### JavaScript
- `AdvogadoViewModel_AoCarregarComponente()` - Função principal
- `AdvogadoViewModel_AplicarMascaras()` - Aplicar máscaras
- `AdvogadoViewModel_ValidarFormulario()` - Validações
- `AdvogadoViewModel_FormatarCampos()` - Formatação
- `AdvogadoViewModel_Confirmar()` - Confirmação

## Funcionalidades do JavaScript

### Máscaras Implementadas
- **CEP**: Formatação automática (00000-000)
- **Número**: Apenas números permitidos

### Validações
- CEP deve ter 8 dígitos
- Número é obrigatório
- Validação em tempo real

## 🚀 **Como Executar - Super Simples!**

### **Para Estudantes e Demonstrações:**
1. **Abra o projeto no Visual Studio**
2. **Pressione F5** - Sem configurações, sem banco, sem complicações!
3. **Acesse a aplicação** - Será redirecionado automaticamente para a lista de advogados
4. **Experimente tudo** - Criar, editar, visualizar, excluir - sem medo de "quebrar" nada!

### **🎓 Perfeito para Aprender:**
- **Sem autorização** - Acesso livre a todas as funcionalidades
- **Dados de exemplo** - Já tem conteúdo para testar
- **Reset automático** - Cada execução é uma "folha em branco"
- **Foco no MVC** - Sem distrações de banco de dados

## Rotas Configuradas

- `/` - Lista de advogados (Index)
- `/Advogado/Create` - Criar novo advogado
- `/Advogado/Edit/{id}` - Editar advogado
- `/Advogado/Details/{id}` - Detalhes do advogado
- `/Advogado/Delete/{id}` - Excluir advogado

## 🛠️ **Tecnologias Utilizadas - Stack de Estudo**

### **Backend:**
- **ASP.NET MVC 5** - Framework principal para aprendizado
- **C#** - Linguagem de programação
- **Armazenamento em Memória** - Simples e didático

### **Frontend:**
- **Bootstrap 5** - Interface responsiva e moderna
- **jQuery** - Manipulação DOM e AJAX
- **JavaScript ES6** - Funcionalidades modernas

### **🎯 Foco Educacional:**
- **Padrão MVC** - Separação clara de responsabilidades
- **Repository Pattern** - Boas práticas de arquitetura
- **Validações** - Client-side e server-side
- **Máscaras** - UX/UI profissional

## 📖 **Objetivos de Estudo Alcançados**

### **✅ Conceitos MVC Demonstrados:**
- **Model** - Classes de domínio, ViewModels, Repositórios
- **View** - Razor views com Bootstrap, validações
- **Controller** - Actions, roteamento, validação de dados

### **✅ Padrões de Desenvolvimento:**
- **Repository Pattern** - Separação de acesso a dados
- **Interface Segregation** - Contratos bem definidos
- **Naming Conventions** - Padrões de nomenclatura consistentes

### **✅ Funcionalidades Web:**
- **CRUD Completo** - Create, Read, Update, Delete
- **Validações** - Server-side e client-side
- **Máscaras** - UX profissional
- **Responsividade** - Bootstrap 5

### **🎓 Ideal Para:**
- **Estudantes de programação**
- **Demonstrações em aula**
- **Portfólio de projetos**
- **Aprendizado de MVC 5**
