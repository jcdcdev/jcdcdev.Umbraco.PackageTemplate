import { defineConfig } from "vite";

export default defineConfig({
  build: {
    lib: {
      entry: "src/index.ts", // your web component source file
      formats: ["es"],
    },
    outDir: "../UmbracoPackageTemplate/wwwroot/App_Plugins/UmbracoPackageTemplate/dist/", // your web component will be saved in this location
    sourcemap: true,
    rollupOptions: {
      external: [/^@umbraco-ui/],
    },
  },
});