import { createRouter, createWebHistory } from "vue-router";
import HomePage from "./components/Pages/HomePage.vue";
import LoginPage from "./components/Pages/LoginPage.vue";
import AboutPage from "./components/Pages/AboutPage.vue";
import ContactPage from "./components/Pages/ContactPage.vue";
import CadastroPage from "./components/Pages/CadastroPage.vue";
import ErroPage from "./components/Pages/ErroPage.vue";
import CarPage from "./components/Pages/CarPage.vue";
import AdmPage from "./components/Pages/AdmPage.vue";

const routes = [
    {
        path: "/",
        name: "Home",
        component: HomePage
    },
    {
        path: "/login",
        name: "Login",
        component: LoginPage
    },
    {
        path: "/sobre",
        name: "Sobre",
        component: AboutPage
    },
    {
        path: "/contato",
        name: "ContactPage",
        component: ContactPage
    },
    {
        path: "/cadastro",
        name: "Cadastro",
        component: CadastroPage
    },
    {
        path: "/erro",
        name: "Erro",
        component: ErroPage
    },
    {
        path: "/carrinho",
        name: "Carrinho",
        component: CarPage
    },
    {
        path: "/adm",
        name: "Adm",
        component: AdmPage
    }
]

const router = createRouter({
    history: createWebHistory(),
    routes
})

export default router;