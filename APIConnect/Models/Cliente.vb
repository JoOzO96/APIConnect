Public Class Cliente
    Private _codigo As Long
    Private _nomecliente As String
    Private _endereco As String
    Private _cep As String

    Private _cpf As String
    'Private Date datanasc;
    Private _identidade As String
    Private _posicao As String
    Private _pai As String
    Private _mae As String
    Private _bairro As String
    Private _trabalho As String
    Private _telefone As String
    Private _fonetrab As String
    Private _cgc As String
    Private _incest As String
    Private _enderecotrab As String
    Private _codprofissao As Long
    Private _codcidade As Long
    Private _responsavel As String
    Private _fone As String
    Private _obs As String
    Private _nume As String
    Private _email As String
    Private _pessoaauto As String
    Private _limitecredito As Decimal
    Private _pessoaauto1 As String
    Private _limitecredito1 As Decimal
    Private _pessoaauto2 As String
    Private _limitecredito2 As String
    Private _limitepessoal As Decimal
    Private _tipocliente As Long
    Private _codvendedor As String
    Private _simples As Boolean
    Private _celular As String
    Private _fisju As String
    Private _conjuge As String
    Private _fretecli As String
    Private _antecipacao As Single
    Private _etiquetas As Boolean
    Private _sistema As Boolean
    Private _vmanu As Decimal
    Private _recibo As Boolean
    Private _codigopgto As Long
    Private _codrepresentante As String
    'Private Date datacadastro;
    'Private Date dataalteracao;
    Private _liberalimite As Boolean
    Private _fantasia As String
    Private _contatocobranca As String
    Private _inativo As Boolean
    Private _clientetipo As Long
    Private _diacobranca As Long
    Private _diaparavencimento As Long

    Public Property codigo As Long
        Get
            Return _codigo
        End Get
        Set(value As Long)
            _codigo = value
        End Set
    End Property

    Public Property nomecliente As String
        Get
            Return _nomecliente
        End Get
        Set(value As String)
            _nomecliente = value
        End Set
    End Property

    Public Property endereco As String
        Get
            Return _endereco
        End Get
        Set(value As String)
            _endereco = value
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

    Public Property cpf As String
        Get
            Return _cpf
        End Get
        Set(value As String)
            _cpf = value
        End Set
    End Property

    Public Property identidade As String
        Get
            Return _identidade
        End Get
        Set(value As String)
            _identidade = value
        End Set
    End Property

    Public Property posicao As String
        Get
            Return _posicao
        End Get
        Set(value As String)
            _posicao = value
        End Set
    End Property

    Public Property pai As String
        Get
            Return _pai
        End Get
        Set(value As String)
            _pai = value
        End Set
    End Property

    Public Property mae As String
        Get
            Return _mae
        End Get
        Set(value As String)
            _mae = value
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

    Public Property trabalho As String
        Get
            Return _trabalho
        End Get
        Set(value As String)
            _trabalho = value
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

    Public Property fonetrab As String
        Get
            Return _fonetrab
        End Get
        Set(value As String)
            _fonetrab = value
        End Set
    End Property

    Public Property cgc As String
        Get
            Return _cgc
        End Get
        Set(value As String)
            _cgc = value
        End Set
    End Property

    Public Property incest As String
        Get
            Return _incest
        End Get
        Set(value As String)
            _incest = value
        End Set
    End Property

    Public Property enderecotrab As String
        Get
            Return _enderecotrab
        End Get
        Set(value As String)
            _enderecotrab = value
        End Set
    End Property

    Public Property codprofissao As Long
        Get
            Return _codprofissao
        End Get
        Set(value As Long)
            _codprofissao = value
        End Set
    End Property

    Public Property codcidade As Long
        Get
            Return _codcidade
        End Get
        Set(value As Long)
            _codcidade = value
        End Set
    End Property

    Public Property responsavel As String
        Get
            Return _responsavel
        End Get
        Set(value As String)
            _responsavel = value
        End Set
    End Property

    Public Property fone As String
        Get
            Return _fone
        End Get
        Set(value As String)
            _fone = value
        End Set
    End Property

    Public Property obs As String
        Get
            Return _obs
        End Get
        Set(value As String)
            _obs = value
        End Set
    End Property

    Public Property nume As String
        Get
            Return _nume
        End Get
        Set(value As String)
            _nume = value
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

    Public Property pessoaauto As String
        Get
            Return _pessoaauto
        End Get
        Set(value As String)
            _pessoaauto = value
        End Set
    End Property

    Public Property limitecredito As Decimal
        Get
            Return _limitecredito
        End Get
        Set(value As Decimal)
            _limitecredito = value
        End Set
    End Property

    Public Property pessoaauto1 As String
        Get
            Return _pessoaauto1
        End Get
        Set(value As String)
            _pessoaauto1 = value
        End Set
    End Property

    Public Property limitecredito1 As Decimal
        Get
            Return _limitecredito1
        End Get
        Set(value As Decimal)
            _limitecredito1 = value
        End Set
    End Property

    Public Property pessoaauto2 As String
        Get
            Return _pessoaauto2
        End Get
        Set(value As String)
            _pessoaauto2 = value
        End Set
    End Property

    Public Property limitecredito2 As String
        Get
            Return _limitecredito2
        End Get
        Set(value As String)
            _limitecredito2 = value
        End Set
    End Property

    Public Property limitepessoal As Decimal
        Get
            Return _limitepessoal
        End Get
        Set(value As Decimal)
            _limitepessoal = value
        End Set
    End Property

    Public Property tipocliente As Long
        Get
            Return _tipocliente
        End Get
        Set(value As Long)
            _tipocliente = value
        End Set
    End Property

    Public Property codvendedor As String
        Get
            Return _codvendedor
        End Get
        Set(value As String)
            _codvendedor = value
        End Set
    End Property

    Public Property simples As Boolean
        Get
            Return _simples
        End Get
        Set(value As Boolean)
            _simples = value
        End Set
    End Property

    Public Property celular As String
        Get
            Return _celular
        End Get
        Set(value As String)
            _celular = value
        End Set
    End Property

    Public Property fisju As String
        Get
            Return _fisju
        End Get
        Set(value As String)
            _fisju = value
        End Set
    End Property

    Public Property conjuge As String
        Get
            Return _conjuge
        End Get
        Set(value As String)
            _conjuge = value
        End Set
    End Property

    Public Property fretecli As String
        Get
            Return _fretecli
        End Get
        Set(value As String)
            _fretecli = value
        End Set
    End Property

    Public Property antecipacao As Single
        Get
            Return _antecipacao
        End Get
        Set(value As Single)
            _antecipacao = value
        End Set
    End Property

    Public Property etiquetas As Boolean
        Get
            Return _etiquetas
        End Get
        Set(value As Boolean)
            _etiquetas = value
        End Set
    End Property

    Public Property sistema As Boolean
        Get
            Return _sistema
        End Get
        Set(value As Boolean)
            _sistema = value
        End Set
    End Property

    Public Property vmanu As Decimal
        Get
            Return _vmanu
        End Get
        Set(value As Decimal)
            _vmanu = value
        End Set
    End Property

    Public Property recibo As Boolean
        Get
            Return _recibo
        End Get
        Set(value As Boolean)
            _recibo = value
        End Set
    End Property

    Public Property codigopgto As Long
        Get
            Return _codigopgto
        End Get
        Set(value As Long)
            _codigopgto = value
        End Set
    End Property

    Public Property codrepresentante As String
        Get
            Return _codrepresentante
        End Get
        Set(value As String)
            _codrepresentante = value
        End Set
    End Property

    Public Property liberalimite As Boolean
        Get
            Return _liberalimite
        End Get
        Set(value As Boolean)
            _liberalimite = value
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

    Public Property contatocobranca As String
        Get
            Return _contatocobranca
        End Get
        Set(value As String)
            _contatocobranca = value
        End Set
    End Property

    Public Property inativo As Boolean
        Get
            Return _inativo
        End Get
        Set(value As Boolean)
            _inativo = value
        End Set
    End Property

    Public Property clientetipo As Long
        Get
            Return _clientetipo
        End Get
        Set(value As Long)
            _clientetipo = value
        End Set
    End Property

    Public Property diacobranca As Long
        Get
            Return _diacobranca
        End Get
        Set(value As Long)
            _diacobranca = value
        End Set
    End Property

    Public Property diaparavencimento As Long
        Get
            Return _diaparavencimento
        End Get
        Set(value As Long)
            _diaparavencimento = value
        End Set
    End Property
End Class