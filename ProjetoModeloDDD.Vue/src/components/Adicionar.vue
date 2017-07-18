<template>
  <div class="adicionar">
    <h3 class="titulo">Adicionar novo contato</h3>
    <hr>
    <div class="form-horizontal col-md-12">
        <div class="form-group col-md-4">
            <div class="row">
                <label class="control-label">Nome do vendedor</label>
            </div>                
            <div class="row">
                <div>
                    <input type="text" name="NomeDoVendedor" class="form-control " />
                </div>
            </div>
        </div>
        <div class="form-group col-md-4">
            <div class="row">
                <label class="control-label">Nome da empresa</label>
            </div>                
            <div class="row">
                <div>
                    <input type="text" name="NomeDaEmpresa" class="form-control " />
                </div>
            </div>
        </div>

        <div class="form-group col-md-4">
            <div class="row">
                <label class="control-label">Nome do contato</label>
            </div>                
            <div class="row">
                <div>
                    <input type="text" name="NomeDoContato" class="form-control " />
                </div>
            </div>
        </div>

        <div class="form-group col-md-4">
            <div class="row">
                <label class="control-label">Sobrenome do contato</label>
            </div>                
            <div class="row">
                <div>
                    <input type="text" name="SobreNomeDoContato" class="form-control " />
                </div>
            </div>
        </div>

        <div class="form-group col-md-4">
            <div class="row">
                <label class="control-label">Email</label>
            </div>                
            <div class="row">
                <div>
                    <input type="text" name="Email" class="form-control " />
                </div>
            </div>
        </div>

        <div class="form-group col-md-4">
            <div class="row">
                <label class="control-label">Telefone</label>
            </div>                
            <div class="row">
                <div>
                    <input type="text" name="Telefone" class="form-control " />
                </div>
            </div>
        </div>

        <div class="form-group col-md-4">
            <div class="row">
                <label class="control-label">Data de validade</label>
            </div>                
            <div class="row">
                <div>
                    <input type="date" name="DataDeValidade" class="form-control "  />
                </div>
            </div>
        </div>

        <div class="form-group col-md-4">
            <div class="row">
                <label class="control-label">Data de contato</label>
            </div>                
            <div class="row">
                <div>
                    <input type="date" name="DataDeContato" class="form-control " />
                </div>
            </div>
        </div>
        <div class="col-md-12">
            <button class="btn btn-success" >Salvar</button>
        </div>
    </div>
  </div>
</template>

<script>
export default {
  name: 'Adicionar',
}
</script>
<style scopped>

</style>

