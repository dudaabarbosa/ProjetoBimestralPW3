import { createRouter, createWebHistory } from "vue-router";
import HomePage from "./components/Pages/HomePage.vue";
import LoginPage from "./components/Pages/LoginPage.vue";
import AboutPage from "./components/Pages/AboutPage.vue";
import ContactPage from "./components/Pages/ContactPage.vue";
import CadastroPage from "./components/Pages/CadastroPage.vue";

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
    }
]

const router = createRouter({
    history: createWebHistory(),
    routes
})

export default router;