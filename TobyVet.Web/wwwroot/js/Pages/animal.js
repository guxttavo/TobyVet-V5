var animal = (function () {
    var configs = {
        urls: {
            cadastrar: "",
            viewCadastrar: "",
            editar: "",
            viewEditar: "",
            listar: ""
        },
    };

    var init = function ($configs) {
        configs = $configs;
    };

    var cadastrar = () => {
        var model = $('#animalForm').serializeObject();

        if (!model.isEmpty) {
            $.post(configs.urls.cadastrar, model).done(function () {
                location.href = configs.urls.listar
            }).fail(function () {
                console.log("deu ruim");
            })
        }
    }

    var viewCadastrar = function () {
        $.get(configs.urls.viewCadastrar).done(function (html) {
            $(".container-lista").hide();
            $(".container-cadastrar").html(html);
            $(".container-cadastrar").show();
        }).fail(function () {
            console.log("deu ruim");
        })
    }

    var editar = function () {
        var model = $("#formEditar").serializeObject();
        $.post(configs.urls.viewEditar, model).done(() => {
            location.href = (configs.urls.listar)
        }).fail(function () {
            console.log("deu ruim");
        })
    }

    var viewEditar = function (id) {
        console.log(id);
        $.get(configs.urls.viewEditar, { id: id }).done(function (html) {
            $(".container-lista").hide();
            $(".buttons").hide();
            $(".container-editar").html(html);
            $(".container-editar").show();
        }).fail(function () {
            console.log("deu ruim");
        })
    }

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

    return {
        init: init,
        cadastrar: cadastrar,
        viewCadastrar: viewCadastrar,
        editar: editar,
        viewEditar: viewEditar,
        listar: listar
    };
})()