let app = new Vue({
    el: "#app",
    data: {
        loginPageTitle: "Login",
        registerPageTitle: "Register",
        registerDto: {
            username: "",
            password: "",
            firstname: "",
            lastname: "",
            dateOfBirth: "",
            checkPassword: "",
        },
        url: "https://localhost:7047/api/account/register",
        errors: null,
        hasError: false,
        loading: false,
    },
    methods: {
        register: async function () {
            this.hasError
            let postData = {
                "firstname": this.registerDto.firstname,
                "lastname": this.registerDto.lastname,
                "dateOfBirth": this.registerDto.dateOfBirth,
                "username": this.registerDto.username,
                "password": this.registerDto.password,
                "checkPassword": this.registerDto.checkPassword
            }
            this.loading = true;
            let result = axios.post(this.url, postData)
                .then(response => {
                   return response
                })
                .catch(error => {
                    this.hasError = true;
                    if (typeof (error.response.data) == "object")
                        this.errors = error.response.data.errors;
                    else
                        this.errors = error.response.data;
                }).finally(() => this.loading = false);
            
        }
    }
});