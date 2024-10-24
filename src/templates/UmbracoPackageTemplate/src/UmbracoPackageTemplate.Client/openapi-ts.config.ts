import {defineConfig} from '@hey-api/openapi-ts';

export default defineConfig({
    input: 'http://localhost:54813/umbraco/swagger/TOKEN_CLIENT_NAME/swagger.json',
    client: "legacy/fetch",
    output: {
        format: 'prettier',
        path: './src/api',
    },
    types: {
        enums: 'typescript',
    },
});
