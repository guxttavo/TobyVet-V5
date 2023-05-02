var animal = (function () {
    var configs = {
        urls: {
            index: "",
            cadastrar: "",
            listar: "",
            mostrarViewCadastrar: "",
            mostrarViewEditar: ""
        },
    };

    var init = function ($configs) {
        configs = $configs;
    };

    // var containerLista = $('.container-lista');

    var mostrarViewEditar = function () {
        $.get(configs.urls.mostrarViewEditar).done(function (html) {
            $(".container-lista").hide();
            $(".container-editar").html(html);
            $(".container-editar").show();
        }).fail(function () {
            console.log("deu ruim");
        })
    }

    var listar = function () {
        $.get(configs.urls.listar).done(function (html) {
            $(".container-cadastrar").hide();
            $(".container-lista").html(html);
            $(".container-lista").show();
        }).fail(function () {
            console.log("deu ruim");
        })
    };
    //responsável apenas pela troca e páginas
    var mostrarViewCadastrar = function () {
        $.get(configs.urls.mostrarViewCadastrar).done(function (html) {
            $(".container-lista").hide();
            $(".container-cadastrar").html(html);
            $(".container-cadastrar").show();
        }).fail(function () {
            console.log("deu ruim");
        })
    }

    var cadastrarAnimal = () => {
        var model = $('#animalForm').serializeObject();

        if (!model.isEmpty) {
            $.post(configs.urls.cadastrar, model).done(function () {
                location.href = configs.urls.listar
            }).fail(function () {
                console.log("deu ruim");
            })
        }
    }

    return {
        init: init,
        cadastrarAnimal: cadastrarAnimal,
        listar: listar,
        mostrarViewCadastrar: mostrarViewCadastrar,
        mostrarViewEditar: mostrarViewEditar
    };
})()