import {defineConfig} from "vite";

export default defineConfig({
    build: {
        lib: {
            entry: ["src/index.ts"],
            formats: ["es"],
        },
        outDir: "../UmbracoPackageTemplate/wwwroot/App_Plugins/UmbracoPackageTemplate/dist/",
        sourcemap: true,
        rollupOptions: {
            external: [/^@umbraco/],
        },
    },
});
