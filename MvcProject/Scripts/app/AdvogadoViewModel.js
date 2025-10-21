// AdvogadoViewModel.js
// Script para gerenciar o formulário de advogado com máscaras e validações

function AdvogadoViewModel_AoCarregarComponente() {
    console.log("Carregando componente AdvogadoViewModel");
    
    // Aplicar máscaras
    AdvogadoViewModel_AplicarMascaras();
    
    // Configurar validações
    AdvogadoViewModel_ConfigurarValidacoes();
    
    // Configurar eventos
    AdvogadoViewModel_ConfigurarEventos();
}

function AdvogadoViewModel_AplicarMascaras() {
    // Máscara para CEP (00000-000)
    if (document.getElementById('cep')) {
        AdvogadoViewModel_AplicarMascaraCep(document.getElementById('cep'));
    }
    
    // Máscara para número (apenas números)
    if (document.getElementById('numero')) {
        AdvogadoViewModel_AplicarMascaraNumero(document.getElementById('numero'));
    }
}

function AdvogadoViewModel_AplicarMascaraCep(elemento) {
    elemento.addEventListener('input', function(e) {
        let valor = e.target.value.replace(/\D/g, '');
        if (valor.length <= 8) {
            valor = valor.replace(/(\d{5})(\d)/, '$1-$2');
        }
        e.target.value = valor;
    });
    
    elemento.addEventListener('keypress', function(e) {
        // Permitir apenas números
        if (!/\d/.test(e.key) && !['Backspace', 'Delete', 'Tab', 'Enter', 'ArrowLeft', 'ArrowRight'].includes(e.key)) {
            e.preventDefault();
        }
    });
}

function AdvogadoViewModel_AplicarMascaraNumero(elemento) {
    elemento.addEventListener('keypress', function(e) {
        // Permitir apenas números
        if (!/\d/.test(e.key) && !['Backspace', 'Delete', 'Tab', 'Enter', 'ArrowLeft', 'ArrowRight'].includes(e.key)) {
            e.preventDefault();
        }
    });
    
    elemento.addEventListener('input', function(e) {
        // Remover qualquer caractere que não seja número
        e.target.value = e.target.value.replace(/\D/g, '');
    });
}

function AdvogadoViewModel_ConfigurarValidacoes() {
    // Validação customizada para CEP
    if (document.getElementById('cep')) {
        document.getElementById('cep').addEventListener('blur', function() {
            AdvogadoViewModel_ValidarCep(this);
        });
    }
    
    // Validação customizada para número
    if (document.getElementById('numero')) {
        document.getElementById('numero').addEventListener('blur', function() {
            AdvogadoViewModel_ValidarNumero(this);
        });
    }
}

function AdvogadoViewModel_ValidarCep(elemento) {
    const valor = elemento.value.replace(/\D/g, '');
    if (valor.length > 0 && valor.length !== 8) {
        elemento.setCustomValidity('CEP deve ter 8 dígitos');
        elemento.reportValidity();
    } else {
        elemento.setCustomValidity('');
    }
}

function AdvogadoViewModel_ValidarNumero(elemento) {
    const valor = elemento.value;
    if (valor.length > 0 && valor.length < 1) {
        elemento.setCustomValidity('Número é obrigatório');
        elemento.reportValidity();
    } else {
        elemento.setCustomValidity('');
    }
}

function AdvogadoViewModel_ConfigurarEventos() {
    // Evento para formatação automática
    const formulario = document.querySelector('form');
    if (formulario) {
        formulario.addEventListener('submit', function(e) {
            if (!AdvogadoViewModel_ValidarFormulario()) {
                e.preventDefault();
            }
        });
    }
}

function AdvogadoViewModel_ValidarFormulario() {
    let valido = true;
    
    // Validar CEP
    const cep = document.getElementById('cep');
    if (cep && cep.value) {
        const cepNumerico = cep.value.replace(/\D/g, '');
        if (cepNumerico.length !== 8) {
            cep.setCustomValidity('CEP deve ter 8 dígitos');
            cep.reportValidity();
            valido = false;
        }
    }
    
    // Validar número
    const numero = document.getElementById('numero');
    if (numero && !numero.value.trim()) {
        numero.setCustomValidity('Número é obrigatório');
        numero.reportValidity();
        valido = false;
    }
    
    return valido;
}

function AdvogadoViewModel_FormatarCampos(formulario) {
    // Formatar CEP
    const cep = formulario.querySelector('#cep');
    if (cep && cep.value) {
        let valor = cep.value.replace(/\D/g, '');
        if (valor.length === 8) {
            cep.value = valor.replace(/(\d{5})(\d{3})/, '$1-$2');
        }
    }
}

function AdvogadoViewModel_CarregarCampos(formulario) {
    // Carregar valores dos campos (útil para edição)
    console.log("Carregando campos do formulário");
}

function AdvogadoViewModel_Confirmar() {
    // Função para confirmação de ações
    console.log("Confirmando ação");
    return AdvogadoViewModel_ValidarFormulario();
}
