```mermaid
sequenceDiagram
    participant N as Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/151.0.0.0 Safari/537.36 Edg/151.0.0.0
    participant D as www.uninove.br
    participant S as Servidor da Clínica Vida+
    N->>D: clinicavidamais.com.br?
    D-->>N: 186.251.39.123
    N->>S: conexão TCP e TLS na porta 443
    N->>S: GET /consultas/agendar
    S-->>N: 200 OK, HTML da agenda
``` 
<!-- A clinica vida precisa de um HTTPS por motivos de segurança para que não haja vazamento de informações de requisições da Clínica, transmitindo assim qualquer tipo de informação íntima que possa ser acessada através de uma requisição  -->