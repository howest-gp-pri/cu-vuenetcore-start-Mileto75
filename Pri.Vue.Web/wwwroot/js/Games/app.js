let app = new Vue({
    el: "#app",
    data: {
        pageTitle: "Our games",
        products: null,
        product: null,
        url: "https://localhost:7047/api/Games",
        loaded: false,
        product: {
            name: "",
            image: "",
            id: null,
            categories: null,
        }
,
    },
    created: function () {
        this.getProducts();
    },
    methods: {
        getProducts: async function () {
            axios.get(this.url)
                .then(result => this.products = result.data)
                .catch(error => this.error = error.data)
                .finally(() => this.loaded = true);
            console.log(this.products);
        },
        showProductInfo: function(product) {
            console.log(product.name);
            this.product = product;
            $("#productModal").modal('show');
        },
        hideProductInfo: function () {
            console.log("test");
            $("#productModal").modal("hide");
        },
    },
});