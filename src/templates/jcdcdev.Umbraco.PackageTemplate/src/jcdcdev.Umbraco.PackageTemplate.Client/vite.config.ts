import { defineConfig } from "vite";

export default defineConfig({
  build: {
    lib: {
      entry: "src/index.ts", // your web component source file
      formats: ["es"],
    },
    outDir: "../jcdcdev.Umbraco.PackageTemplate/wwwroot/App_Plugins/jcdcdev.Umbraco.PackageTemplate/dist/", // your web component will be saved in this location
    sourcemap: true,
    rollupOptions: {
      external: [/^@umbraco-ui/],
    },
  },
});