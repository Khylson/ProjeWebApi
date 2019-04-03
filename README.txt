Desafio. 

- criei um projeto ASP.NET Web Api de nome (ProjetoWebApi), usei ADO.NET Enty  Data Model de nome (DataConnection) na pasta DataConnection para conexão com banco de daods, adicionei dois Models para {get;set;} (ClasseMarca, ClassePatrimonio) na pasta Models, e usei nas classes o comando "[Required(ErrorMessage)]" nos campos obrigatórios com mensagem de erro "campo obrigatório" para tratamento de erros em casos de não serem preenchidos. 

- criei dos Controllers (MaracasControllers e   PatrimoniosController) onde fiz os codigos das 5 etapas (Get, Get id, Post, Put e Delete). para que a busca dos dados na tabela Marca não fossem repetidas usei o camando "Distinct()" na busca da lista no banco de dados. 

- para que o número de Tombo fosse gerado automaticamente especifiquei como id (primary key) da tabela Patrimonio que se auto-incrementa  "identity(1,1)" not null, para que não fosse editado pelo usário omite dos campos da edição da atabela Patrimonio apresentado para o usuário, porém o usuário não poderá ver e nem editar o id (N_Tombo) da tabela Patrimonio.também foi omitido na edição da tabela Marca o id (MarcaId), de tal forma o formulario só aprsentará o nome da Marca pois que id (MarcaId) é auto-incremento "identity(1,1)" not null, poém só poderá ser editado o nome da Marca. 

- para garantir que os dados chegassem via JSON usei a linha de código "var json = config.Formatters.JsonFormatter;" na pasta App_Start arquivo "WebApiConfig.cs" para formatar os dados e chegarem em Json.  

- usei o try pensando em caso de tratamento de erros, embora não implementados os metodos que retoram erros, 
 como desenvolverdor é ideal pensar nos eventuais erros que o usuário pode encontara na utilização dos sistema, e informar sobre os erros encontrados é importante em normais de bom programador. 
 
- Na pasta db_Script contem os scripts do banco de dados.
