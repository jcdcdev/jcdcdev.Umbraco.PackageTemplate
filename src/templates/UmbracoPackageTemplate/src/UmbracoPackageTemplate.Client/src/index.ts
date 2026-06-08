import {UmbEntryPointOnInit} from "@umbraco-cms/backoffice/extension-api";

export const onInit: UmbEntryPointOnInit = (_host, extensionRegistry) => {
    // Register manifests here:
    extensionRegistry.registerMany([]);
};
