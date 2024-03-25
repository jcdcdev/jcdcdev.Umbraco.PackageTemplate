import {customElement} from "lit/decorators.js";
import {css, html, LitElement} from "lit";

@customElement('custom-element')
export default class CustomElement extends LitElement {

	constructor() {
		super();
	}

	render() {
		return html`
			<div>
				<h1>Custom Element</h1>
				<p>UmbracoPackageTemplate</p>
			</div>`;
	}

	static styles = [css
		`
          div {
            background-color: #f4f4f4;
            border: 1px solid #ccc;
            padding: 10px;
            margin: 10px;
          }
		`
	];
}

declare global {
	interface HTMLElementTagNameMap {
		'custom-element': CustomElement;
	}
}