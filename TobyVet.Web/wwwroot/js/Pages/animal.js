var animal = (function () {
    var configs = {
        urls: {
            index: "",
            cadastrar: "",
            listar: "",
            mostrarViewCadastrar: "",
        },
    };

    var init = function ($configs) {
        configs = $configs;
    };

    // var containerLista = $('.container-lista');

    var listar = function () {
        $.get(configs.urls.listar).done(function (html) {
            $(".container-cadastrar").hide();
            $(".container-lista").html(html);
            $(".container-lista").show();
        }).fail(function () {
            console.log("deu ruim");
        })
    };

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
            $.post(configs.urls.cadastrar, model).done(() => {
            });
        }
    }

    return {
        init: init,
        cadastrarAnimal: cadastrarAnimal,
        listar: listar,
        mostrarViewCadastrar: mostrarViewCadastrar
    };
})()