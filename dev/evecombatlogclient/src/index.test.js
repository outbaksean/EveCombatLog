import React from "react";
import { render, unmountComponentAtNode } from "react-dom";
import { act } from "react-dom/test-utils";

import Fittings from "./index";
import { isTSAnyKeyword } from "@babel/types";

let container = null;
beforeEach(() => {
    //setup a DOM element as a render target
    container = document.createElement("div");
    document.body.appendChild(container);
});

afterEach(() => {
    //cleanup on exiting
    unmountComponentAtNode(container);
    container.remove();
    container = null;
});

it("testtest", () => {
    act(() => {
        render(<Fittings />, container);
    });
    expect(container.textContent).toBe("First");
});