import { createRouter, createWebHistory } from "vue-router";
import HomePage from "./components/Pages/HomePage.vue";
import LoginPage from "./components/Pages/LoginPage.vue";
import AboutPage from "./components/Pages/AboutPage.vue";
import ContactPage from "./components/Pages/ContactPage.vue";

const routes = [
    {
        path: "/home",
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
        name: "Contato",
        component: ContactPage
    }
]

const router = createRouter({
    history: createWebHistory(),
    routes
})

export default router;