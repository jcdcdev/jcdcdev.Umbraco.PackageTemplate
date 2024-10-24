import {UMB_AUTH_CONTEXT} from "@umbraco-cms/backoffice/auth";
import {OpenAPI} from "./api";
import {UmbEntryPointOnInit} from "@umbraco-cms/backoffice/extension-api";

export const onInit: UmbEntryPointOnInit = (_host, extensionRegistry) => {
    // Register manifests here:
    extensionRegistry.registerMany([]);

    // Add OpenAPI configuration
    _host.consumeContext(UMB_AUTH_CONTEXT, (_auth) => {
        const umbOpenApi = _auth.getOpenApiConfiguration();
        OpenAPI.TOKEN = umbOpenApi.token;
        OpenAPI.BASE = umbOpenApi.base;
        OpenAPI.WITH_CREDENTIALS = umbOpenApi.withCredentials;
    });
};
