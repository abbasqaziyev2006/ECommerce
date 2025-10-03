(function ($) {
    "use strict";

    var filters = {
        minPrice: 0,
        maxPrice: 0,
        size: null,
        color: null,
        availability: null,
        brands: null,
        sale: false,
    };

    /* Price Range */
    var rangeTwoPrice = function () {
        var slider = document.getElementById("price-value-range");
        if (!slider) return;

        var min = parseInt(slider.getAttribute("data-min"));
        var max = parseInt(slider.getAttribute("data-max"));
        filters.minPrice = min;
        filters.maxPrice = max;

        noUiSlider.create(slider, {
            start: [min, max],
            connect: true,
            step: 1,
            range: { min, max },
            format: { from: parseInt, to: parseInt }
        });

        slider.noUiSlider.on("update", function (val) {
            filters.minPrice = parseInt(val[0]);
            filters.maxPrice = parseInt(val[1]);
            $("#price-min-value").text(filters.minPrice);
            $("#price-max-value").text(filters.maxPrice);
            applyFilters();
        });
    };

    /* Filter Inputs */
    var bindFilters = function () {
        $(document).on("change", 'input[name="size"], input[name="color"], input[name="availability"], input[name="brand"]', function () {
            var name = $(this).attr("name");
            filters[name] = $(this).is(":checked") ? $(this).val() : null;
            applyFilters();
        });

        $(".shop-sale-text").click(function () {
            filters.sale = !filters.sale;
            $(this).toggleClass("active", filters.sale);
            applyFilters();
        });

        $(document).on("click", ".remove-tag", function () {
            var type = $(this).data("filter");
            if (!type) return;

            filters[type] = null;
            $(`input[name="${type}"]`).prop("checked", false);
            if (type === "sale") $(".shop-sale-text").removeClass("active");
            if (type === "price") {
                var slider = document.getElementById("price-value-range");
                slider.noUiSlider.set([slider.getAttribute("data-min"), slider.getAttribute("data-max")]);
            }
            applyFilters();
        });
    };

    /* Apply Filters */
    function applyFilters() {
        $(".wrapper-shop .card-product").each(function () {
            var p = $(this);
            var price = parseFloat(p.find(".current-price").text().replace(/[^\d.]/g, ''));
            var show = true;

            if (price < filters.minPrice || price > filters.maxPrice) show = false;
            if (filters.size && !p.find(`.size-item:contains('${filters.size}')`).length) show = false;
            if (filters.color && !p.find(`.color-swatch:contains('${filters.color}')`).length) show = false;
            if (filters.availability && filters.availability !== p.data("availability")) show = false;
            if (filters.sale && !p.find(".on-sale-wrap").length) show = false;
            if (filters.brands && filters.brands !== p.data("brand")) show = false;

            p.toggle(show);
        });

        updateLoadMoreButton();
    }

    /* Layout Switch */
    var swLayoutShop = function () {
        $(document).on("click", ".tf-view-layout-switch", function () {
            var layout = $(this).data("value-layout");
            $(".tf-view-layout-switch").removeClass("active");
            $(this).addClass("active");
            if (layout === "list") {
                $("#gridLayout").hide();
                $("#listLayout").show();
            } else {
                $("#listLayout").hide();
                $("#gridLayout").show().removeClass().addClass(`wrapper-shop tf-grid-layout ${layout}`);
            }
        });
    };

    /* Load More */
    var loadItem = function () {
        var gridPage = 1;
        var listPage = 1;

        function loadMore(layout) {
            var page = layout.is("#gridLayout") ? gridPage : listPage;
            var url = "/Shop/LoadMore?page=" + page;

            $.get(url, function (data) {
                if (!data.trim()) return;
                layout.append(data);
                if (layout.is("#gridLayout")) gridPage++;
                else listPage++;
                applyFilters();
            });
        }

        $("#loadMoreGridBtn").on("click", function () {
            loadMore($("#gridLayout"));
        });

        $("#loadMoreListBtn").on("click", function () {
            loadMore($("#listLayout"));
        });
    };

    function updateLoadMoreButton() {
        $(".loadItem.hidden").length === 0 ? $(".load-more-btn").hide() : $(".load-more-btn").show();
    }

    /* Init */
    $(function () {
        rangeTwoPrice();
        bindFilters();
        swLayoutShop();
        loadItem();
    });

})(jQuery);
