import { customElement, html, LitElement, property } from "lit-element";

@customElement('custom-element')
export default class CustomElement extends LitElement {


    constructor() {
        super();
    }

    render() {
        return html`<div>
            <h1>Custom Element</h1>
            <p>jcdcdev.Umbraco.PackageTemplate</p>
        </div>`;
    }
}

declare global {
    interface HTMLElementTagNameMap {
        'custom-element': CustomElement;
    }
}