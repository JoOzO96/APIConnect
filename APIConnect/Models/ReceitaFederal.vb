Imports APIConnect

Public Class ReceitaFederal
    Private _atividade_principal As AtividadePrincipal()
    Private _data_situacao As String
    Private _complemento As String
    Private _nome As String
    Private _uf As String
    Private _telefone As String
    Private _atividades_secundarias As AtividadesSecundaria()
    Private _qsa As Qsa()
    Private _situacao As String
    Private _bairro As String
    Private _logradouro As String
    Private _numero As String
    Private _cep As String
    Private _municipio As String
    Private _porte As String
    Private _abertura As String
    Private _natureza_juridica As String
    Private _fantasia As String
    Private _cnpj As String
    Private _ultima_atualizacao As DateTime
    Private _status As String
    Private _tipo As String
    Private _email As String
    Private _efr As String
    Private _motivo_situacao As String
    Private _situacao_especial As String
    Private _data_situacao_especial As String
    Private _capital_social As String

    Public Property atividade_principal As AtividadePrincipal()
        Get
            Return _atividade_principal
        End Get
        Set(value As AtividadePrincipal())
            _atividade_principal = value
        End Set
    End Property

    Public Property data_situacao As String
        Get
            Return _data_situacao
        End Get
        Set(value As String)
            _data_situacao = value
        End Set
    End Property

    Public Property complemento As String
        Get
            Return _complemento
        End Get
        Set(value As String)
            _complemento = value
        End Set
    End Property

    Public Property nome As String
        Get
            Return _nome
        End Get
        Set(value As String)
            _nome = value
        End Set
    End Property

    Public Property uf As String
        Get
            Return _uf
        End Get
        Set(value As String)
            _uf = value
        End Set
    End Property

    Public Property telefone As String
        Get
            Return _telefone
        End Get
        Set(value As String)
            _telefone = value
        End Set
    End Property

    Public Property atividades_secundarias As AtividadesSecundaria()
        Get
            Return _atividades_secundarias
        End Get
        Set(value As AtividadesSecundaria())
            _atividades_secundarias = value
        End Set
    End Property

    Public Property qsa As Qsa()
        Get
            Return _qsa
        End Get
        Set(value As Qsa())
            _qsa = value
        End Set
    End Property

    Public Property situacao As String
        Get
            Return _situacao
        End Get
        Set(value As String)
            _situacao = value
        End Set
    End Property

    Public Property bairro As String
        Get
            Return _bairro
        End Get
        Set(value As String)
            _bairro = value
        End Set
    End Property

    Public Property logradouro As String
        Get
            Return _logradouro
        End Get
        Set(value As String)
            _logradouro = value
        End Set
    End Property

    Public Property numero As String
        Get
            Return _numero
        End Get
        Set(value As String)
            _numero = value
        End Set
    End Property

    Public Property cep As String
        Get
            Return _cep
        End Get
        Set(value As String)
            _cep = value
        End Set
    End Property

    Public Property municipio As String
        Get
            Return _municipio
        End Get
        Set(value As String)
            _municipio = value
        End Set
    End Property

    Public Property porte As String
        Get
            Return _porte
        End Get
        Set(value As String)
            _porte = value
        End Set
    End Property

    Public Property abertura As String
        Get
            Return _abertura
        End Get
        Set(value As String)
            _abertura = value
        End Set
    End Property

    Public Property natureza_juridica As String
        Get
            Return _natureza_juridica
        End Get
        Set(value As String)
            _natureza_juridica = value
        End Set
    End Property

    Public Property fantasia As String
        Get
            Return _fantasia
        End Get
        Set(value As String)
            _fantasia = value
        End Set
    End Property

    Public Property cnpj As String
        Get
            Return _cnpj
        End Get
        Set(value As String)
            _cnpj = value
        End Set
    End Property

    Public Property ultima_atualizacao As Date
        Get
            Return _ultima_atualizacao
        End Get
        Set(value As Date)
            _ultima_atualizacao = value
        End Set
    End Property

    Public Property status As String
        Get
            Return _status
        End Get
        Set(value As String)
            _status = value
        End Set
    End Property

    Public Property tipo As String
        Get
            Return _tipo
        End Get
        Set(value As String)
            _tipo = value
        End Set
    End Property

    Public Property email As String
        Get
            Return _email
        End Get
        Set(value As String)
            _email = value
        End Set
    End Property

    Public Property efr As String
        Get
            Return _efr
        End Get
        Set(value As String)
            _efr = value
        End Set
    End Property

    Public Property motivo_situacao As String
        Get
            Return _motivo_situacao
        End Get
        Set(value As String)
            _motivo_situacao = value
        End Set
    End Property

    Public Property situacao_especial As String
        Get
            Return _situacao_especial
        End Get
        Set(value As String)
            _situacao_especial = value
        End Set
    End Property

    Public Property data_situacao_especial As String
        Get
            Return _data_situacao_especial
        End Get
        Set(value As String)
            _data_situacao_especial = value
        End Set
    End Property

    Public Property capital_social As String
        Get
            Return _capital_social
        End Get
        Set(value As String)
            _capital_social = value
        End Set
    End Property
End Class