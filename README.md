# Cálculo de divisores e primos

Acesse o link abaixo para conferir o resultado 😁

https://numerosdivisores.azurewebsites.net/NumerosDivisoresEPrimos?numero=45


## Desempenho
Como o cálculo é feito em memória e não há utilização de bancos de dados o desempenho naturalmente é alto, porém, caso haja necessidade de mais desempenho ainda, é possível fazer ajustes cirúrgicos no código tais como substituir algumas classes por structs, calcular os divisores e primos num só laço e utilizar métodos estáticos. 

## Escala, Disponibilidade e Resiliência
Como a API está publicada no Microsoft Azure, estes itens podem ser configurados e gerenciados com apenas cliques e um cartão de crédito. A demanda é que determina se a melhor escala aplicada seria vertical, horizontal ou as duas. Tanto o aumento de poder do hardware como a multiplicação do números de instâncias ativas organizadas com um Load Balancer poderiam garantir a escala apropriada para suprir a demanda. Também podemos configurar recursos de  redundância geográficas de zonas para garantir disponibilidade e resiliência do serviço. Mesmo que um datacenter falhe, os outros conseguem manter o serviço online. 

