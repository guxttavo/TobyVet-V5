var animal = (function () {
    var configs = {
        urls: {
            cadastrar: "",
            viewCadastrar: "",
            editar: "",
            viewEditar: "",
            index: "",
            listar: "",
            excluir: ""
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
            })
        }
    }

    var viewCadastrar = function () {
        $.get(configs.urls.viewCadastrar).done(function (html) {
            $(".container-lista").hide();
            $(".container-cadastrar").html(html);
            $(".container-cadastrar").show();
        }).fail(function () {
        })
    }

    var editar = function () {
        var model = $("#formEditar").serializeObject();
        console.log(model);
        $.post(configs.urls.editar, model).done(() => {
            location.href = configs.urls.index
        }).fail(function () {
            console.log("deu ruim");
        })
    }

    var viewEditar = function (id) {
        $.get(configs.urls.viewEditar, { id: id }).done(function (html) {
            $(".container-lista").hide();
            $(".buttons").hide();
            $(".container-editar").html(html);
            $(".container-editar").show();
        }).fail(function () {
        })
    }

    // var containerLista = $('.container-lista');
    var listar = function () {
        $.get(configs.urls.listar).done(function (html) {
            $(".container-cadastrar").hide();
            $(".container-lista").html(html);
            $(".container-lista").show();
        }).fail(function () {
        })
    };

    var excluir = function (id) {
        var model = {Id: id};
        $.post(configs.urls.excluir, model).done(() => {
            listar();
        }).fail(function () {
        })
    }

    return {
        init: init,
        cadastrar: cadastrar,
        viewCadastrar: viewCadastrar,
        editar: editar,
        viewEditar: viewEditar,
        listar: listar,
        excluir: excluir
    };
})()