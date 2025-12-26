namespace Feliz.Bulma

open System

module private ClassLiterals =
    [<Literal>]
    let ``is-clearfix`` = "is-clearfix"

    [<Literal>]
    let ``is-pulled-left`` = "is-pulled-left"

    [<Literal>]
    let ``is-pulled-right`` = "is-pulled-right"

    [<Literal>]
    let ``is-marginless`` = "is-marginless"

    [<Literal>]
    let ``is-paddingless`` = "is-paddingless"

    [<Literal>]
    let ``is-overlay`` = "is-overlay"

    [<Literal>]
    let ``is-clipped`` = "is-clipped"

    [<Literal>]
    let ``is-radiusless`` = "is-radiusless"

    [<Literal>]
    let ``is-shadowless`` = "is-shadowless"

    [<Literal>]
    let ``is-unselectable`` = "is-unselectable"

    [<Literal>]
    let ``is-clickable`` = "is-clickable"

    [<Literal>]
    let ``is-relative`` = "is-relative"

    [<Literal>]
    let ``is-invisible`` = "is-invisible"

    [<Literal>]
    let ``is-hidden`` = "is-hidden"

    [<Literal>]
    let ``is-hidden-mobile`` = "is-hidden-mobile"

    [<Literal>]
    let ``is-hidden-tablet-only`` = "is-hidden-tablet-only"

    [<Literal>]
    let ``is-hidden-desktop-only`` = "is-hidden-desktop-only"

    [<Literal>]
    let ``is-hidden-widescreen-only`` = "is-hidden-widescreen-only"

    [<Literal>]
    let ``is-hidden-touch`` = "is-hidden-touch"

    [<Literal>]
    let ``is-hidden-tablet`` = "is-hidden-tablet"

    [<Literal>]
    let ``is-hidden-desktop`` = "is-hidden-desktop"

    [<Literal>]
    let ``is-hidden-widescreen`` = "is-hidden-widescreen"

    [<Literal>]
    let ``is-hidden-fullhd`` = "is-hidden-fullhd"

    [<Literal>]
    let ``is-sr-only`` = "is-sr-only"

    [<Literal>]
    let ``is-block`` = "is-block"

    [<Literal>]
    let ``is-block-mobile`` = "is-block-mobile"

    [<Literal>]
    let ``is-block-tablet-only`` = "is-block-tablet-only"

    [<Literal>]
    let ``is-block-desktop-only`` = "is-block-desktop-only"

    [<Literal>]
    let ``is-block-widescreen-only`` = "is-block-widescreen-only"

    [<Literal>]
    let ``is-block-touch`` = "is-block-touch"

    [<Literal>]
    let ``is-block-tablet`` = "is-block-tablet"

    [<Literal>]
    let ``is-block-desktop`` = "is-block-desktop"

    [<Literal>]
    let ``is-block-widescreen`` = "is-block-widescreen"

    [<Literal>]
    let ``is-block-fullhd`` = "is-block-fullhd"

    [<Literal>]
    let ``is-flex`` = "is-flex"

    [<Literal>]
    let ``is-flex-mobile`` = "is-flex-mobile"

    [<Literal>]
    let ``is-flex-tablet-only`` = "is-flex-tablet-only"

    [<Literal>]
    let ``is-flex-desktop-only`` = "is-flex-desktop-only"

    [<Literal>]
    let ``is-flex-widescreen-only`` = "is-flex-widescreen-only"

    [<Literal>]
    let ``is-flex-touch`` = "is-flex-touch"

    [<Literal>]
    let ``is-flex-tablet`` = "is-flex-tablet"

    [<Literal>]
    let ``is-flex-desktop`` = "is-flex-desktop"

    [<Literal>]
    let ``is-flex-widescreen`` = "is-flex-widescreen"

    [<Literal>]
    let ``is-flex-fullhd`` = "is-flex-fullhd"

    [<Literal>]
    let ``is-flex-direction-row`` = "is-flex-direction-row"

    [<Literal>]
    let ``is-flex-direction-row-reverse`` = "is-flex-direction-row-reverse"

    [<Literal>]
    let ``is-flex-direction-column`` = "is-flex-direction-column"

    [<Literal>]
    let ``is-flex-direction-column-reverse`` = "is-flex-direction-column-reverse"

    [<Literal>]
    let ``is-flex-wrap-nowrap`` = "is-flex-wrap-nowrap"

    [<Literal>]
    let ``is-flex-wrap-wrap`` = "is-flex-wrap-wrap"

    [<Literal>]
    let ``is-flex-wrap-wrap-reverse`` = "is-flex-wrap-wrap"

    [<Literal>]
    let ``is-justify-content-flex-start`` = "is-justify-content-flex-start"

    [<Literal>]
    let ``is-justify-content-flex-end`` = "is-justify-content-flex-end"

    [<Literal>]
    let ``is-justify-content-center`` = "is-justify-content-center"

    [<Literal>]
    let ``is-justify-content-space-between`` = "is-justify-content-space-between"

    [<Literal>]
    let ``is-justify-content-space-around`` = "is-justify-content-space-around"

    [<Literal>]
    let ``is-justify-content-space-evenly`` = "is-justify-content-space-evenly"

    [<Literal>]
    let ``is-justify-content-start`` = "is-justify-content-start"

    [<Literal>]
    let ``is-justify-content-end`` = "is-justify-content-end"

    [<Literal>]
    let ``is-justify-content-left`` = "is-justify-content-left"

    [<Literal>]
    let ``is-justify-content-right`` = "is-justify-content-right"

    [<Literal>]
    let ``is-align-content-flex-start`` = "is-align-content-flex-start"

    [<Literal>]
    let ``is-align-content-flex-end`` = "is-align-content-flex-end"

    [<Literal>]
    let ``is-align-content-center`` = "is-align-content-center"

    [<Literal>]
    let ``is-align-content-space-between`` = "is-align-content-space-between"

    [<Literal>]
    let ``is-align-content-space-around`` = "is-align-content-space-around"

    [<Literal>]
    let ``is-align-content-space-evenly`` = "is-align-content-space-evenly"

    [<Literal>]
    let ``is-align-content-stretch`` = "is-align-content-stretch"

    [<Literal>]
    let ``is-align-content-start`` = "is-align-content-start"

    [<Literal>]
    let ``is-align-content-end`` = "is-align-content-end"

    [<Literal>]
    let ``is-align-content-baseline`` = "is-align-content-baseline"

    [<Literal>]
    let ``is-align-items-stretch`` = "is-align-items-stretch"

    [<Literal>]
    let ``is-align-items-flex-start`` = "is-align-items-flex-start"

    [<Literal>]
    let ``is-align-items-flex-end`` = "is-align-items-flex-end"

    [<Literal>]
    let ``is-align-items-center`` = "is-align-items-center"

    [<Literal>]
    let ``is-align-items-baseline`` = "is-align-items-baseline"

    [<Literal>]
    let ``is-align-items-start`` = "is-align-items-start"

    [<Literal>]
    let ``is-align-items-end`` = "is-align-items-end"

    [<Literal>]
    let ``is-align-items-self-start`` = "is-align-items-self-start"

    [<Literal>]
    let ``is-align-items-self-end`` = "is-align-items-self-end"

    [<Literal>]
    let ``is-align-self-auto`` = "is-align-self-auto"

    [<Literal>]
    let ``is-align-self-flex-start`` = "is-align-self-flex-start"

    [<Literal>]
    let ``is-align-self-flex-end`` = "is-align-self-flex-end"

    [<Literal>]
    let ``is-align-self-center`` = "is-align-self-center"

    [<Literal>]
    let ``is-align-self-baseline`` = "is-align-self-baseline"

    [<Literal>]
    let ``is-align-self-stretch`` = "is-align-self-stretch"

    [<Literal>]
    let ``is-flex-grow-0`` = "is-flex-grow-0"

    [<Literal>]
    let ``is-flex-grow-1`` = "is-flex-grow-1"

    [<Literal>]
    let ``is-flex-grow-2`` = "is-flex-grow-2"

    [<Literal>]
    let ``is-flex-grow-3`` = "is-flex-grow-3"

    [<Literal>]
    let ``is-flex-grow-4`` = "is-flex-grow-4"

    [<Literal>]
    let ``is-flex-grow-5`` = "is-flex-grow-5"

    [<Literal>]
    let ``is-flex-shrink-0`` = "is-flex-shrink-0"

    [<Literal>]
    let ``is-flex-shrink-1`` = "is-flex-shrink-1"

    [<Literal>]
    let ``is-flex-shrink-2`` = "is-flex-shrink-2"

    [<Literal>]
    let ``is-flex-shrink-3`` = "is-flex-shrink-3"

    [<Literal>]
    let ``is-flex-shrink-4`` = "is-flex-shrink-4"

    [<Literal>]
    let ``is-flex-shrink-5`` = "is-flex-shrink-5"

    [<Literal>]
    let ``is-inline`` = "is-inline"

    [<Literal>]
    let ``is-inline-mobile`` = "is-inline-mobile"

    [<Literal>]
    let ``is-inline-tablet-only`` = "is-inline-tablet-only"

    [<Literal>]
    let ``is-inline-desktop-only`` = "is-inline-desktop-only"

    [<Literal>]
    let ``is-inline-widescreen-only`` = "is-inline-widescreen-only"

    [<Literal>]
    let ``is-inline-touch`` = "is-inline-touch"

    [<Literal>]
    let ``is-inline-tablet`` = "is-inline-tablet"

    [<Literal>]
    let ``is-inline-desktop`` = "is-inline-desktop"

    [<Literal>]
    let ``is-inline-widescreen`` = "is-inline-widescreen"

    [<Literal>]
    let ``is-inline-fullhd`` = "is-inline-fullhd"

    [<Literal>]
    let ``is-inline-block`` = "is-inline-block"

    [<Literal>]
    let ``is-inline-block-mobile`` = "is-inline-block-mobile"

    [<Literal>]
    let ``is-inline-block-tablet-only`` = "is-inline-block-tablet-only"

    [<Literal>]
    let ``is-inline-block-desktop-only`` = "is-inline-block-desktop-only"

    [<Literal>]
    let ``is-inline-block-widescreen-only`` = "is-inline-block-widescreen-only"

    [<Literal>]
    let ``is-inline-block-touch`` = "is-inline-block-touch"

    [<Literal>]
    let ``is-inline-block-tablet`` = "is-inline-block-tablet"

    [<Literal>]
    let ``is-inline-block-desktop`` = "is-inline-block-desktop"

    [<Literal>]
    let ``is-inline-block-widescreen`` = "is-inline-block-widescreen"

    [<Literal>]
    let ``is-inline-block-fullhd`` = "is-inline-block-fullhd"

    [<Literal>]
    let ``is-inline-flex`` = "is-inline-flex"

    [<Literal>]
    let ``is-inline-flex-mobile`` = "is-inline-flex-mobile"

    [<Literal>]
    let ``is-inline-flex-tablet-only`` = "is-inline-flex-tablet-only"

    [<Literal>]
    let ``is-inline-flex-desktop-only`` = "is-inline-flex-desktop-only"

    [<Literal>]
    let ``is-inline-flex-widescreen-only`` = "is-inline-flex-widescreen-only"

    [<Literal>]
    let ``is-inline-flex-touch`` = "is-inline-flex-touch"

    [<Literal>]
    let ``is-inline-flex-tablet`` = "is-inline-flex-tablet"

    [<Literal>]
    let ``is-inline-flex-desktop`` = "is-inline-flex-desktop"

    [<Literal>]
    let ``is-inline-flex-widescreen`` = "is-inline-flex-widescreen"

    [<Literal>]
    let ``is-inline-flex-fullhd`` = "is-inline-flex-fullhd"

    [<Literal>]
    let ``is-size-1`` = "is-size-1"

    [<Literal>]
    let ``is-size-2`` = "is-size-2"

    [<Literal>]
    let ``is-size-3`` = "is-size-3"

    [<Literal>]
    let ``is-size-4`` = "is-size-4"

    [<Literal>]
    let ``is-size-5`` = "is-size-5"

    [<Literal>]
    let ``is-size-6`` = "is-size-6"

    [<Literal>]
    let ``is-size-7`` = "is-size-7"

    [<Literal>]
    let ``is-size-1-mobile`` = "is-size-1-mobile"

    [<Literal>]
    let ``is-size-2-mobile`` = "is-size-2-mobile"

    [<Literal>]
    let ``is-size-3-mobile`` = "is-size-3-mobile"

    [<Literal>]
    let ``is-size-4-mobile`` = "is-size-4-mobile"

    [<Literal>]
    let ``is-size-5-mobile`` = "is-size-5-mobile"

    [<Literal>]
    let ``is-size-6-mobile`` = "is-size-6-mobile"

    [<Literal>]
    let ``is-size-7-mobile`` = "is-size-7-mobile"

    [<Literal>]
    let ``is-size-1-tablet`` = "is-size-1-tablet"

    [<Literal>]
    let ``is-size-2-tablet`` = "is-size-2-tablet"

    [<Literal>]
    let ``is-size-3-tablet`` = "is-size-3-tablet"

    [<Literal>]
    let ``is-size-4-tablet`` = "is-size-4-tablet"

    [<Literal>]
    let ``is-size-5-tablet`` = "is-size-5-tablet"

    [<Literal>]
    let ``is-size-6-tablet`` = "is-size-6-tablet"

    [<Literal>]
    let ``is-size-7-tablet`` = "is-size-7-tablet"

    [<Literal>]
    let ``is-size-1-touch`` = "is-size-1-touch"

    [<Literal>]
    let ``is-size-2-touch`` = "is-size-2-touch"

    [<Literal>]
    let ``is-size-3-touch`` = "is-size-3-touch"

    [<Literal>]
    let ``is-size-4-touch`` = "is-size-4-touch"

    [<Literal>]
    let ``is-size-5-touch`` = "is-size-5-touch"

    [<Literal>]
    let ``is-size-6-touch`` = "is-size-6-touch"

    [<Literal>]
    let ``is-size-7-touch`` = "is-size-7-touch"

    [<Literal>]
    let ``is-size-1-desktop`` = "is-size-1-desktop"

    [<Literal>]
    let ``is-size-2-desktop`` = "is-size-2-desktop"

    [<Literal>]
    let ``is-size-3-desktop`` = "is-size-3-desktop"

    [<Literal>]
    let ``is-size-4-desktop`` = "is-size-4-desktop"

    [<Literal>]
    let ``is-size-5-desktop`` = "is-size-5-desktop"

    [<Literal>]
    let ``is-size-6-desktop`` = "is-size-6-desktop"

    [<Literal>]
    let ``is-size-7-desktop`` = "is-size-7-desktop"

    [<Literal>]
    let ``is-size-1-widescreen`` = "is-size-1-widescreen"

    [<Literal>]
    let ``is-size-2-widescreen`` = "is-size-2-widescreen"

    [<Literal>]
    let ``is-size-3-widescreen`` = "is-size-3-widescreen"

    [<Literal>]
    let ``is-size-4-widescreen`` = "is-size-4-widescreen"

    [<Literal>]
    let ``is-size-5-widescreen`` = "is-size-5-widescreen"

    [<Literal>]
    let ``is-size-6-widescreen`` = "is-size-6-widescreen"

    [<Literal>]
    let ``is-size-7-widescreen`` = "is-size-7-widescreen"

    [<Literal>]
    let ``is-size-1-fullhd`` = "is-size-1-fullhd"

    [<Literal>]
    let ``is-size-2-fullhd`` = "is-size-2-fullhd"

    [<Literal>]
    let ``is-size-3-fullhd`` = "is-size-3-fullhd"

    [<Literal>]
    let ``is-size-4-fullhd`` = "is-size-4-fullhd"

    [<Literal>]
    let ``is-size-5-fullhd`` = "is-size-5-fullhd"

    [<Literal>]
    let ``is-size-6-fullhd`` = "is-size-6-fullhd"

    [<Literal>]
    let ``is-size-7-fullhd`` = "is-size-7-fullhd"

    [<Literal>]
    let ``is-family-sans-serif`` = "is-family-sans-serif"

    [<Literal>]
    let ``is-family-monospace`` = "is-family-monospace"

    [<Literal>]
    let ``is-family-primary`` = "is-family-primary"

    [<Literal>]
    let ``is-family-secondary`` = "is-family-secondary"

    [<Literal>]
    let ``is-family-code`` = "is-family-code"

    [<Literal>]
    let ``is-capitalized`` = "is-capitalized"

    [<Literal>]
    let ``is-lowercase`` = "is-lowercase"

    [<Literal>]
    let ``is-uppercase`` = "is-uppercase"

    [<Literal>]
    let ``is-italic`` = "is-italic"

    [<Literal>]
    let ``is-underlined`` = "is-underlined"

    [<Literal>]
    let ``has-text-weight-light`` = "has-text-weight-light"

    [<Literal>]
    let ``has-text-weight-normal`` = "has-text-weight-normal"

    [<Literal>]
    let ``has-text-weight-medium`` = "has-text-weight-medium"

    [<Literal>]
    let ``has-text-weight-semibold`` = "has-text-weight-semibold"

    [<Literal>]
    let ``has-text-weight-bold`` = "has-text-weight-bold"

    [<Literal>]
    let ``has-text-weight-extrabold`` = "has-text-weight-extrabold"

    [<Literal>]
    let ``has-text-centered`` = "has-text-centered"

    [<Literal>]
    let ``has-text-justified`` = "has-text-justified"

    [<Literal>]
    let ``has-text-left`` = "has-text-left"

    [<Literal>]
    let ``has-text-right`` = "has-text-right"

    [<Literal>]
    let ``has-text-centered-mobile`` = "has-text-centered-mobile"

    [<Literal>]
    let ``has-text-justified-mobile`` = "has-text-justified-mobile"

    [<Literal>]
    let ``has-text-left-mobile`` = "has-text-left-mobile"

    [<Literal>]
    let ``has-text-right-mobile`` = "has-text-right-mobile"

    [<Literal>]
    let ``has-text-centered-tablet`` = "has-text-centered-tablet"

    [<Literal>]
    let ``has-text-justified-tablet`` = "has-text-justified-tablet"

    [<Literal>]
    let ``has-text-left-tablet`` = "has-text-left-tablet"

    [<Literal>]
    let ``has-text-right-tablet`` = "has-text-right-tablet"

    [<Literal>]
    let ``has-text-centered-tablet-only`` = "has-text-centered-tablet-only"

    [<Literal>]
    let ``has-text-justified-tablet-only`` = "has-text-justified-tablet-only"

    [<Literal>]
    let ``has-text-left-tablet-only`` = "has-text-left-tablet-only"

    [<Literal>]
    let ``has-text-right-tablet-only`` = "has-text-right-tablet-only"

    [<Literal>]
    let ``has-text-centered-touch`` = "has-text-centered-touch"

    [<Literal>]
    let ``has-text-justified-touch`` = "has-text-justified-touch"

    [<Literal>]
    let ``has-text-left-touch`` = "has-text-left-touch"

    [<Literal>]
    let ``has-text-right-touch`` = "has-text-right-touch"

    [<Literal>]
    let ``has-text-centered-desktop`` = "has-text-centered-desktop"

    [<Literal>]
    let ``has-text-justified-desktop`` = "has-text-justified-desktop"

    [<Literal>]
    let ``has-text-left-desktop`` = "has-text-left-desktop"

    [<Literal>]
    let ``has-text-right-desktop`` = "has-text-right-desktop"

    [<Literal>]
    let ``has-text-centered-desktop-only`` = "has-text-centered-desktop-only"

    [<Literal>]
    let ``has-text-justified-desktop-only`` = "has-text-justified-desktop-only"

    [<Literal>]
    let ``has-text-left-desktop-only`` = "has-text-left-desktop-only"

    [<Literal>]
    let ``has-text-right-desktop-only`` = "has-text-right-desktop-only"

    [<Literal>]
    let ``has-text-centered-widescreen`` = "has-text-centered-widescreen"

    [<Literal>]
    let ``has-text-justified-widescreen`` = "has-text-justified-widescreen"

    [<Literal>]
    let ``has-text-left-widescreen`` = "has-text-left-widescreen"

    [<Literal>]
    let ``has-text-right-widescreen`` = "has-text-right-widescreen"

    [<Literal>]
    let ``has-text-centered-widescreen-only`` = "has-text-centered-widescreen-only"

    [<Literal>]
    let ``has-text-justified-widescreen-only`` = "has-text-justified-widescreen-only"

    [<Literal>]
    let ``has-text-left-widescreen-only`` = "has-text-left-widescreen-only"

    [<Literal>]
    let ``has-text-right-widescreen-only`` = "has-text-right-widescreen-only"

    [<Literal>]
    let ``has-text-centered-fullhd`` = "has-text-centered-fullhd"

    [<Literal>]
    let ``has-text-justified-fullhd`` = "has-text-justified-fullhd"

    [<Literal>]
    let ``has-text-left-fullhd`` = "has-text-left-fullhd"

    [<Literal>]
    let ``has-text-right-fullhd`` = "has-text-right-fullhd"

    [<Literal>]
    let ``is-white`` = "is-white"

    [<Literal>]
    let ``is-black`` = "is-black"

    [<Literal>]
    let ``is-light`` = "is-light"

    [<Literal>]
    let ``is-dark`` = "is-dark"

    [<Literal>]
    let ``is-primary`` = "is-primary"

    [<Literal>]
    let ``is-link`` = "is-link"

    [<Literal>]
    let ``is-info`` = "is-info"

    [<Literal>]
    let ``is-success`` = "is-success"

    [<Literal>]
    let ``is-warning`` = "is-warning"

    [<Literal>]
    let ``is-danger`` = "is-danger"

    [<Literal>]
    let ``is-text`` = "is-text"

    [<Literal>]
    let ``has-text-white`` = "has-text-white"

    [<Literal>]
    let ``has-text-black`` = "has-text-black"

    [<Literal>]
    let ``has-text-light`` = "has-text-light"

    [<Literal>]
    let ``has-text-dark`` = "has-text-dark"

    [<Literal>]
    let ``has-text-text`` = "has-text-text"

    [<Literal>]
    let ``has-text-text-invert`` = "has-text-text-invert"

    [<Literal>]
    let ``has-text-text-dark`` = "has-text-text-dark"

    [<Literal>]
    let ``has-text-text-dark-invert`` = "has-text-text-dark-invert"

    [<Literal>]
    let ``has-text-text-light`` = "has-text-text-light"

    [<Literal>]
    let ``has-text-text-light-invert`` = "has-text-text-light-invert"

    [<Literal>]
    let ``has-text-text-soft`` = "has-text-text-soft"

    [<Literal>]
    let ``has-text-text-soft-invert`` = "has-text-text-soft-invert"

    [<Literal>]
    let ``has-text-text-bold`` = "has-text-text-bold"

    [<Literal>]
    let ``has-text-text-bold-invert`` = "has-text-text-bold-invert"

    [<Literal>]
    let ``has-text-text-on-scheme`` = "has-text-text-on-scheme"

    [<Literal>]
    let ``has-text-text-on-scheme-invert`` = "has-text-text-on-scheme-invert"

    [<Literal>]
    let ``has-text-text-00`` = "has-text-text-00"

    [<Literal>]
    let ``has-text-text-00-invert`` = "has-text-text-00-invert"

    [<Literal>]
    let ``has-text-text-05`` = "has-text-text-05"

    [<Literal>]
    let ``has-text-text-05-invert`` = "has-text-text-05-invert"

    [<Literal>]
    let ``has-text-text-10`` = "has-text-text-10"

    [<Literal>]
    let ``has-text-text-10-invert`` = "has-text-text-10-invert"

    [<Literal>]
    let ``has-text-text-15`` = "has-text-text-15"

    [<Literal>]
    let ``has-text-text-15-invert`` = "has-text-text-15-invert"

    [<Literal>]
    let ``has-text-text-20`` = "has-text-text-20"

    [<Literal>]
    let ``has-text-text-20-invert`` = "has-text-text-20-invert"

    [<Literal>]
    let ``has-text-text-25`` = "has-text-text-25"

    [<Literal>]
    let ``has-text-text-25-invert`` = "has-text-text-25-invert"

    [<Literal>]
    let ``has-text-text-30`` = "has-text-text-30"

    [<Literal>]
    let ``has-text-text-30-invert`` = "has-text-text-30-invert"

    [<Literal>]
    let ``has-text-text-35`` = "has-text-text-35"

    [<Literal>]
    let ``has-text-text-35-invert`` = "has-text-text-35-invert"

    [<Literal>]
    let ``has-text-text-40`` = "has-text-text-40"

    [<Literal>]
    let ``has-text-text-40-invert`` = "has-text-text-40-invert"

    [<Literal>]
    let ``has-text-text-45`` = "has-text-text-45"

    [<Literal>]
    let ``has-text-text-45-invert`` = "has-text-text-45-invert"

    [<Literal>]
    let ``has-text-text-50`` = "has-text-text-50"

    [<Literal>]
    let ``has-text-text-50-invert`` = "has-text-text-50-invert"

    [<Literal>]
    let ``has-text-text-55`` = "has-text-text-55"

    [<Literal>]
    let ``has-text-text-55-invert`` = "has-text-text-55-invert"

    [<Literal>]
    let ``has-text-text-60`` = "has-text-text-60"

    [<Literal>]
    let ``has-text-text-60-invert`` = "has-text-text-60-invert"

    [<Literal>]
    let ``has-text-text-65`` = "has-text-text-65"

    [<Literal>]
    let ``has-text-text-65-invert`` = "has-text-text-65-invert"

    [<Literal>]
    let ``has-text-text-70`` = "has-text-text-70"

    [<Literal>]
    let ``has-text-text-70-invert`` = "has-text-text-70-invert"

    [<Literal>]
    let ``has-text-text-75`` = "has-text-text-75"

    [<Literal>]
    let ``has-text-text-75-invert`` = "has-text-text-75-invert"

    [<Literal>]
    let ``has-text-text-80`` = "has-text-text-80"

    [<Literal>]
    let ``has-text-text-80-invert`` = "has-text-text-80-invert"

    [<Literal>]
    let ``has-text-text-85`` = "has-text-text-85"

    [<Literal>]
    let ``has-text-text-85-invert`` = "has-text-text-85-invert"

    [<Literal>]
    let ``has-text-text-90`` = "has-text-text-90"

    [<Literal>]
    let ``has-text-text-90-invert`` = "has-text-text-90-invert"

    [<Literal>]
    let ``has-text-text-95`` = "has-text-text-95"

    [<Literal>]
    let ``has-text-text-95-invert`` = "has-text-text-95-invert"

    [<Literal>]
    let ``has-text-text-100`` = "has-text-text-100"

    [<Literal>]
    let ``has-text-text-100-invert`` = "has-text-text-100-invert"

    [<Literal>]
    let ``has-text-primary`` = "has-text-primary"

    [<Literal>]
    let ``has-text-primary-invert`` = "has-text-primary-invert"

    [<Literal>]
    let ``has-text-primary-dark`` = "has-text-primary-dark"

    [<Literal>]
    let ``has-text-primary-dark-invert`` = "has-text-primary-dark-invert"

    [<Literal>]
    let ``has-text-primary-light`` = "has-text-primary-light"

    [<Literal>]
    let ``has-text-primary-light-invert`` = "has-text-primary-light-invert"

    [<Literal>]
    let ``has-text-primary-soft`` = "has-text-primary-soft"

    [<Literal>]
    let ``has-text-primary-soft-invert`` = "has-text-primary-soft-invert"

    [<Literal>]
    let ``has-text-primary-bold`` = "has-text-primary-bold"

    [<Literal>]
    let ``has-text-primary-bold-invert`` = "has-text-primary-bold-invert"

    [<Literal>]
    let ``has-text-primary-on-scheme`` = "has-text-primary-on-scheme"

    [<Literal>]
    let ``has-text-primary-on-scheme-invert`` = "has-text-primary-on-scheme-invert"

    [<Literal>]
    let ``has-text-primary-00`` = "has-text-primary-00"

    [<Literal>]
    let ``has-text-primary-00-invert`` = "has-text-primary-00-invert"

    [<Literal>]
    let ``has-text-primary-05`` = "has-text-primary-05"

    [<Literal>]
    let ``has-text-primary-05-invert`` = "has-text-primary-05-invert"

    [<Literal>]
    let ``has-text-primary-10`` = "has-text-primary-10"

    [<Literal>]
    let ``has-text-primary-10-invert`` = "has-text-primary-10-invert"

    [<Literal>]
    let ``has-text-primary-15`` = "has-text-primary-15"

    [<Literal>]
    let ``has-text-primary-15-invert`` = "has-text-primary-15-invert"

    [<Literal>]
    let ``has-text-primary-20`` = "has-text-primary-20"

    [<Literal>]
    let ``has-text-primary-20-invert`` = "has-text-primary-20-invert"

    [<Literal>]
    let ``has-text-primary-25`` = "has-text-primary-25"

    [<Literal>]
    let ``has-text-primary-25-invert`` = "has-text-primary-25-invert"

    [<Literal>]
    let ``has-text-primary-30`` = "has-text-primary-30"

    [<Literal>]
    let ``has-text-primary-30-invert`` = "has-text-primary-30-invert"

    [<Literal>]
    let ``has-text-primary-35`` = "has-text-primary-35"

    [<Literal>]
    let ``has-text-primary-35-invert`` = "has-text-primary-35-invert"

    [<Literal>]
    let ``has-text-primary-40`` = "has-text-primary-40"

    [<Literal>]
    let ``has-text-primary-40-invert`` = "has-text-primary-40-invert"

    [<Literal>]
    let ``has-text-primary-45`` = "has-text-primary-45"

    [<Literal>]
    let ``has-text-primary-45-invert`` = "has-text-primary-45-invert"

    [<Literal>]
    let ``has-text-primary-50`` = "has-text-primary-50"

    [<Literal>]
    let ``has-text-primary-50-invert`` = "has-text-primary-50-invert"

    [<Literal>]
    let ``has-text-primary-55`` = "has-text-primary-55"

    [<Literal>]
    let ``has-text-primary-55-invert`` = "has-text-primary-55-invert"

    [<Literal>]
    let ``has-text-primary-60`` = "has-text-primary-60"

    [<Literal>]
    let ``has-text-primary-60-invert`` = "has-text-primary-60-invert"

    [<Literal>]
    let ``has-text-primary-65`` = "has-text-primary-65"

    [<Literal>]
    let ``has-text-primary-65-invert`` = "has-text-primary-65-invert"

    [<Literal>]
    let ``has-text-primary-70`` = "has-text-primary-70"

    [<Literal>]
    let ``has-text-primary-70-invert`` = "has-text-primary-70-invert"

    [<Literal>]
    let ``has-text-primary-75`` = "has-text-primary-75"

    [<Literal>]
    let ``has-text-primary-75-invert`` = "has-text-primary-75-invert"

    [<Literal>]
    let ``has-text-primary-80`` = "has-text-primary-80"

    [<Literal>]
    let ``has-text-primary-80-invert`` = "has-text-primary-80-invert"

    [<Literal>]
    let ``has-text-primary-85`` = "has-text-primary-85"

    [<Literal>]
    let ``has-text-primary-85-invert`` = "has-text-primary-85-invert"

    [<Literal>]
    let ``has-text-primary-90`` = "has-text-primary-90"

    [<Literal>]
    let ``has-text-primary-90-invert`` = "has-text-primary-90-invert"

    [<Literal>]
    let ``has-text-primary-95`` = "has-text-primary-95"

    [<Literal>]
    let ``has-text-primary-95-invert`` = "has-text-primary-95-invert"

    [<Literal>]
    let ``has-text-primary-100`` = "has-text-primary-100"

    [<Literal>]
    let ``has-text-primary-100-invert`` = "has-text-primary-100-invert"

    [<Literal>]
    let ``has-text-info`` = "has-text-info"

    [<Literal>]
    let ``has-text-info-invert`` = "has-text-info-invert"

    [<Literal>]
    let ``has-text-info-dark`` = "has-text-info-dark"

    [<Literal>]
    let ``has-text-info-dark-invert`` = "has-text-info-dark-invert"

    [<Literal>]
    let ``has-text-info-light`` = "has-text-info-light"

    [<Literal>]
    let ``has-text-info-light-invert`` = "has-text-info-light-invert"

    [<Literal>]
    let ``has-text-info-soft`` = "has-text-info-soft"

    [<Literal>]
    let ``has-text-info-soft-invert`` = "has-text-info-soft-invert"

    [<Literal>]
    let ``has-text-info-bold`` = "has-text-info-bold"

    [<Literal>]
    let ``has-text-info-bold-invert`` = "has-text-info-bold-invert"

    [<Literal>]
    let ``has-text-info-on-scheme`` = "has-text-info-on-scheme"

    [<Literal>]
    let ``has-text-info-on-scheme-invert`` = "has-text-info-on-scheme-invert"

    [<Literal>]
    let ``has-text-info-00`` = "has-text-info-00"

    [<Literal>]
    let ``has-text-info-00-invert`` = "has-text-info-00-invert"

    [<Literal>]
    let ``has-text-info-05`` = "has-text-info-05"

    [<Literal>]
    let ``has-text-info-05-invert`` = "has-text-info-05-invert"

    [<Literal>]
    let ``has-text-info-10`` = "has-text-info-10"

    [<Literal>]
    let ``has-text-info-10-invert`` = "has-text-info-10-invert"

    [<Literal>]
    let ``has-text-info-15`` = "has-text-info-15"

    [<Literal>]
    let ``has-text-info-15-invert`` = "has-text-info-15-invert"

    [<Literal>]
    let ``has-text-info-20`` = "has-text-info-20"

    [<Literal>]
    let ``has-text-info-20-invert`` = "has-text-info-20-invert"

    [<Literal>]
    let ``has-text-info-25`` = "has-text-info-25"

    [<Literal>]
    let ``has-text-info-25-invert`` = "has-text-info-25-invert"

    [<Literal>]
    let ``has-text-info-30`` = "has-text-info-30"

    [<Literal>]
    let ``has-text-info-30-invert`` = "has-text-info-30-invert"

    [<Literal>]
    let ``has-text-info-35`` = "has-text-info-35"

    [<Literal>]
    let ``has-text-info-35-invert`` = "has-text-info-35-invert"

    [<Literal>]
    let ``has-text-info-40`` = "has-text-info-40"

    [<Literal>]
    let ``has-text-info-40-invert`` = "has-text-info-40-invert"

    [<Literal>]
    let ``has-text-info-45`` = "has-text-info-45"

    [<Literal>]
    let ``has-text-info-45-invert`` = "has-text-info-45-invert"

    [<Literal>]
    let ``has-text-info-50`` = "has-text-info-50"

    [<Literal>]
    let ``has-text-info-50-invert`` = "has-text-info-50-invert"

    [<Literal>]
    let ``has-text-info-55`` = "has-text-info-55"

    [<Literal>]
    let ``has-text-info-55-invert`` = "has-text-info-55-invert"

    [<Literal>]
    let ``has-text-info-60`` = "has-text-info-60"

    [<Literal>]
    let ``has-text-info-60-invert`` = "has-text-info-60-invert"

    [<Literal>]
    let ``has-text-info-65`` = "has-text-info-65"

    [<Literal>]
    let ``has-text-info-65-invert`` = "has-text-info-65-invert"

    [<Literal>]
    let ``has-text-info-70`` = "has-text-info-70"

    [<Literal>]
    let ``has-text-info-70-invert`` = "has-text-info-70-invert"

    [<Literal>]
    let ``has-text-info-75`` = "has-text-info-75"

    [<Literal>]
    let ``has-text-info-75-invert`` = "has-text-info-75-invert"

    [<Literal>]
    let ``has-text-info-80`` = "has-text-info-80"

    [<Literal>]
    let ``has-text-info-80-invert`` = "has-text-info-80-invert"

    [<Literal>]
    let ``has-text-info-85`` = "has-text-info-85"

    [<Literal>]
    let ``has-text-info-85-invert`` = "has-text-info-85-invert"

    [<Literal>]
    let ``has-text-info-90`` = "has-text-info-90"

    [<Literal>]
    let ``has-text-info-90-invert`` = "has-text-info-90-invert"

    [<Literal>]
    let ``has-text-info-95`` = "has-text-info-95"

    [<Literal>]
    let ``has-text-info-95-invert`` = "has-text-info-95-invert"

    [<Literal>]
    let ``has-text-info-100`` = "has-text-info-100"

    [<Literal>]
    let ``has-text-info-100-invert`` = "has-text-info-100-invert"

    [<Literal>]
    let ``has-text-link`` = "has-text-link"

    [<Literal>]
    let ``has-text-link-invert`` = "has-text-link-invert"

    [<Literal>]
    let ``has-text-link-dark`` = "has-text-link-dark"

    [<Literal>]
    let ``has-text-link-dark-invert`` = "has-text-link-dark-invert"

    [<Literal>]
    let ``has-text-link-light`` = "has-text-link-light"

    [<Literal>]
    let ``has-text-link-light-invert`` = "has-text-link-light-invert"

    [<Literal>]
    let ``has-text-link-soft`` = "has-text-link-soft"

    [<Literal>]
    let ``has-text-link-soft-invert`` = "has-text-link-soft-invert"

    [<Literal>]
    let ``has-text-link-bold`` = "has-text-link-bold"

    [<Literal>]
    let ``has-text-link-bold-invert`` = "has-text-link-bold-invert"

    [<Literal>]
    let ``has-text-link-on-scheme`` = "has-text-link-on-scheme"

    [<Literal>]
    let ``has-text-link-on-scheme-invert`` = "has-text-link-on-scheme-invert"

    [<Literal>]
    let ``has-text-link-00`` = "has-text-link-00"

    [<Literal>]
    let ``has-text-link-00-invert`` = "has-text-link-00-invert"

    [<Literal>]
    let ``has-text-link-05`` = "has-text-link-05"

    [<Literal>]
    let ``has-text-link-05-invert`` = "has-text-link-05-invert"

    [<Literal>]
    let ``has-text-link-10`` = "has-text-link-10"

    [<Literal>]
    let ``has-text-link-10-invert`` = "has-text-link-10-invert"

    [<Literal>]
    let ``has-text-link-15`` = "has-text-link-15"

    [<Literal>]
    let ``has-text-link-15-invert`` = "has-text-link-15-invert"

    [<Literal>]
    let ``has-text-link-20`` = "has-text-link-20"

    [<Literal>]
    let ``has-text-link-20-invert`` = "has-text-link-20-invert"

    [<Literal>]
    let ``has-text-link-25`` = "has-text-link-25"

    [<Literal>]
    let ``has-text-link-25-invert`` = "has-text-link-25-invert"

    [<Literal>]
    let ``has-text-link-30`` = "has-text-link-30"

    [<Literal>]
    let ``has-text-link-30-invert`` = "has-text-link-30-invert"

    [<Literal>]
    let ``has-text-link-35`` = "has-text-link-35"

    [<Literal>]
    let ``has-text-link-35-invert`` = "has-text-link-35-invert"

    [<Literal>]
    let ``has-text-link-40`` = "has-text-link-40"

    [<Literal>]
    let ``has-text-link-40-invert`` = "has-text-link-40-invert"

    [<Literal>]
    let ``has-text-link-45`` = "has-text-link-45"

    [<Literal>]
    let ``has-text-link-45-invert`` = "has-text-link-45-invert"

    [<Literal>]
    let ``has-text-link-50`` = "has-text-link-50"

    [<Literal>]
    let ``has-text-link-50-invert`` = "has-text-link-50-invert"

    [<Literal>]
    let ``has-text-link-55`` = "has-text-link-55"

    [<Literal>]
    let ``has-text-link-55-invert`` = "has-text-link-55-invert"

    [<Literal>]
    let ``has-text-link-60`` = "has-text-link-60"

    [<Literal>]
    let ``has-text-link-60-invert`` = "has-text-link-60-invert"

    [<Literal>]
    let ``has-text-link-65`` = "has-text-link-65"

    [<Literal>]
    let ``has-text-link-65-invert`` = "has-text-link-65-invert"

    [<Literal>]
    let ``has-text-link-70`` = "has-text-link-70"

    [<Literal>]
    let ``has-text-link-70-invert`` = "has-text-link-70-invert"

    [<Literal>]
    let ``has-text-link-75`` = "has-text-link-75"

    [<Literal>]
    let ``has-text-link-75-invert`` = "has-text-link-75-invert"

    [<Literal>]
    let ``has-text-link-80`` = "has-text-link-80"

    [<Literal>]
    let ``has-text-link-80-invert`` = "has-text-link-80-invert"

    [<Literal>]
    let ``has-text-link-85`` = "has-text-link-85"

    [<Literal>]
    let ``has-text-link-85-invert`` = "has-text-link-85-invert"

    [<Literal>]
    let ``has-text-link-90`` = "has-text-link-90"

    [<Literal>]
    let ``has-text-link-90-invert`` = "has-text-link-90-invert"

    [<Literal>]
    let ``has-text-link-95`` = "has-text-link-95"

    [<Literal>]
    let ``has-text-link-95-invert`` = "has-text-link-95-invert"

    [<Literal>]
    let ``has-text-link-100`` = "has-text-link-100"

    [<Literal>]
    let ``has-text-link-100-invert`` = "has-text-link-100-invert"

    [<Literal>]
    let ``has-text-success`` = "has-text-success"

    [<Literal>]
    let ``has-text-success-invert`` = "has-text-success-invert"

    [<Literal>]
    let ``has-text-success-dark`` = "has-text-success-dark"

    [<Literal>]
    let ``has-text-success-dark-invert`` = "has-text-success-dark-invert"

    [<Literal>]
    let ``has-text-success-light`` = "has-text-success-light"

    [<Literal>]
    let ``has-text-success-light-invert`` = "has-text-success-light-invert"

    [<Literal>]
    let ``has-text-success-soft`` = "has-text-success-soft"

    [<Literal>]
    let ``has-text-success-soft-invert`` = "has-text-success-soft-invert"

    [<Literal>]
    let ``has-text-success-bold`` = "has-text-success-bold"

    [<Literal>]
    let ``has-text-success-bold-invert`` = "has-text-success-bold-invert"

    [<Literal>]
    let ``has-text-success-on-scheme`` = "has-text-success-on-scheme"

    [<Literal>]
    let ``has-text-success-on-scheme-invert`` = "has-text-success-on-scheme-invert"

    [<Literal>]
    let ``has-text-success-00`` = "has-text-success-00"

    [<Literal>]
    let ``has-text-success-00-invert`` = "has-text-success-00-invert"

    [<Literal>]
    let ``has-text-success-05`` = "has-text-success-05"

    [<Literal>]
    let ``has-text-success-05-invert`` = "has-text-success-05-invert"

    [<Literal>]
    let ``has-text-success-10`` = "has-text-success-10"

    [<Literal>]
    let ``has-text-success-10-invert`` = "has-text-success-10-invert"

    [<Literal>]
    let ``has-text-success-15`` = "has-text-success-15"

    [<Literal>]
    let ``has-text-success-15-invert`` = "has-text-success-15-invert"

    [<Literal>]
    let ``has-text-success-20`` = "has-text-success-20"

    [<Literal>]
    let ``has-text-success-20-invert`` = "has-text-success-20-invert"

    [<Literal>]
    let ``has-text-success-25`` = "has-text-success-25"

    [<Literal>]
    let ``has-text-success-25-invert`` = "has-text-success-25-invert"

    [<Literal>]
    let ``has-text-success-30`` = "has-text-success-30"

    [<Literal>]
    let ``has-text-success-30-invert`` = "has-text-success-30-invert"

    [<Literal>]
    let ``has-text-success-35`` = "has-text-success-35"

    [<Literal>]
    let ``has-text-success-35-invert`` = "has-text-success-35-invert"

    [<Literal>]
    let ``has-text-success-40`` = "has-text-success-40"

    [<Literal>]
    let ``has-text-success-40-invert`` = "has-text-success-40-invert"

    [<Literal>]
    let ``has-text-success-45`` = "has-text-success-45"

    [<Literal>]
    let ``has-text-success-45-invert`` = "has-text-success-45-invert"

    [<Literal>]
    let ``has-text-success-50`` = "has-text-success-50"

    [<Literal>]
    let ``has-text-success-50-invert`` = "has-text-success-50-invert"

    [<Literal>]
    let ``has-text-success-55`` = "has-text-success-55"

    [<Literal>]
    let ``has-text-success-55-invert`` = "has-text-success-55-invert"

    [<Literal>]
    let ``has-text-success-60`` = "has-text-success-60"

    [<Literal>]
    let ``has-text-success-60-invert`` = "has-text-success-60-invert"

    [<Literal>]
    let ``has-text-success-65`` = "has-text-success-65"

    [<Literal>]
    let ``has-text-success-65-invert`` = "has-text-success-65-invert"

    [<Literal>]
    let ``has-text-success-70`` = "has-text-success-70"

    [<Literal>]
    let ``has-text-success-70-invert`` = "has-text-success-70-invert"

    [<Literal>]
    let ``has-text-success-75`` = "has-text-success-75"

    [<Literal>]
    let ``has-text-success-75-invert`` = "has-text-success-75-invert"

    [<Literal>]
    let ``has-text-success-80`` = "has-text-success-80"

    [<Literal>]
    let ``has-text-success-80-invert`` = "has-text-success-80-invert"

    [<Literal>]
    let ``has-text-success-85`` = "has-text-success-85"

    [<Literal>]
    let ``has-text-success-85-invert`` = "has-text-success-85-invert"

    [<Literal>]
    let ``has-text-success-90`` = "has-text-success-90"

    [<Literal>]
    let ``has-text-success-90-invert`` = "has-text-success-90-invert"

    [<Literal>]
    let ``has-text-success-95`` = "has-text-success-95"

    [<Literal>]
    let ``has-text-success-95-invert`` = "has-text-success-95-invert"

    [<Literal>]
    let ``has-text-success-100`` = "has-text-success-100"

    [<Literal>]
    let ``has-text-success-100-invert`` = "has-text-success-100-invert"

    [<Literal>]
    let ``has-text-warning`` = "has-text-warning"

    [<Literal>]
    let ``has-text-warning-invert`` = "has-text-warning-invert"

    [<Literal>]
    let ``has-text-warning-dark`` = "has-text-warning-dark"

    [<Literal>]
    let ``has-text-warning-dark-invert`` = "has-text-warning-dark-invert"

    [<Literal>]
    let ``has-text-warning-light`` = "has-text-warning-light"

    [<Literal>]
    let ``has-text-warning-light-invert`` = "has-text-warning-light-invert"

    [<Literal>]
    let ``has-text-warning-soft`` = "has-text-warning-soft"

    [<Literal>]
    let ``has-text-warning-soft-invert`` = "has-text-warning-soft-invert"

    [<Literal>]
    let ``has-text-warning-bold`` = "has-text-warning-bold"

    [<Literal>]
    let ``has-text-warning-bold-invert`` = "has-text-warning-bold-invert"

    [<Literal>]
    let ``has-text-warning-on-scheme`` = "has-text-warning-on-scheme"

    [<Literal>]
    let ``has-text-warning-on-scheme-invert`` = "has-text-warning-on-scheme-invert"

    [<Literal>]
    let ``has-text-warning-00`` = "has-text-warning-00"

    [<Literal>]
    let ``has-text-warning-00-invert`` = "has-text-warning-00-invert"

    [<Literal>]
    let ``has-text-warning-05`` = "has-text-warning-05"

    [<Literal>]
    let ``has-text-warning-05-invert`` = "has-text-warning-05-invert"

    [<Literal>]
    let ``has-text-warning-10`` = "has-text-warning-10"

    [<Literal>]
    let ``has-text-warning-10-invert`` = "has-text-warning-10-invert"

    [<Literal>]
    let ``has-text-warning-15`` = "has-text-warning-15"

    [<Literal>]
    let ``has-text-warning-15-invert`` = "has-text-warning-15-invert"

    [<Literal>]
    let ``has-text-warning-20`` = "has-text-warning-20"

    [<Literal>]
    let ``has-text-warning-20-invert`` = "has-text-warning-20-invert"

    [<Literal>]
    let ``has-text-warning-25`` = "has-text-warning-25"

    [<Literal>]
    let ``has-text-warning-25-invert`` = "has-text-warning-25-invert"

    [<Literal>]
    let ``has-text-warning-30`` = "has-text-warning-30"

    [<Literal>]
    let ``has-text-warning-30-invert`` = "has-text-warning-30-invert"

    [<Literal>]
    let ``has-text-warning-35`` = "has-text-warning-35"

    [<Literal>]
    let ``has-text-warning-35-invert`` = "has-text-warning-35-invert"

    [<Literal>]
    let ``has-text-warning-40`` = "has-text-warning-40"

    [<Literal>]
    let ``has-text-warning-40-invert`` = "has-text-warning-40-invert"

    [<Literal>]
    let ``has-text-warning-45`` = "has-text-warning-45"

    [<Literal>]
    let ``has-text-warning-45-invert`` = "has-text-warning-45-invert"

    [<Literal>]
    let ``has-text-warning-50`` = "has-text-warning-50"

    [<Literal>]
    let ``has-text-warning-50-invert`` = "has-text-warning-50-invert"

    [<Literal>]
    let ``has-text-warning-55`` = "has-text-warning-55"

    [<Literal>]
    let ``has-text-warning-55-invert`` = "has-text-warning-55-invert"

    [<Literal>]
    let ``has-text-warning-60`` = "has-text-warning-60"

    [<Literal>]
    let ``has-text-warning-60-invert`` = "has-text-warning-60-invert"

    [<Literal>]
    let ``has-text-warning-65`` = "has-text-warning-65"

    [<Literal>]
    let ``has-text-warning-65-invert`` = "has-text-warning-65-invert"

    [<Literal>]
    let ``has-text-warning-70`` = "has-text-warning-70"

    [<Literal>]
    let ``has-text-warning-70-invert`` = "has-text-warning-70-invert"

    [<Literal>]
    let ``has-text-warning-75`` = "has-text-warning-75"

    [<Literal>]
    let ``has-text-warning-75-invert`` = "has-text-warning-75-invert"

    [<Literal>]
    let ``has-text-warning-80`` = "has-text-warning-80"

    [<Literal>]
    let ``has-text-warning-80-invert`` = "has-text-warning-80-invert"

    [<Literal>]
    let ``has-text-warning-85`` = "has-text-warning-85"

    [<Literal>]
    let ``has-text-warning-85-invert`` = "has-text-warning-85-invert"

    [<Literal>]
    let ``has-text-warning-90`` = "has-text-warning-90"

    [<Literal>]
    let ``has-text-warning-90-invert`` = "has-text-warning-90-invert"

    [<Literal>]
    let ``has-text-warning-95`` = "has-text-warning-95"

    [<Literal>]
    let ``has-text-warning-95-invert`` = "has-text-warning-95-invert"

    [<Literal>]
    let ``has-text-warning-100`` = "has-text-warning-100"

    [<Literal>]
    let ``has-text-warning-100-invert`` = "has-text-warning-100-invert"

    [<Literal>]
    let ``has-text-danger`` = "has-text-danger"

    [<Literal>]
    let ``has-text-danger-invert`` = "has-text-danger-invert"

    [<Literal>]
    let ``has-text-danger-dark`` = "has-text-danger-dark"

    [<Literal>]
    let ``has-text-danger-dark-invert`` = "has-text-danger-dark-invert"

    [<Literal>]
    let ``has-text-danger-light`` = "has-text-danger-light"

    [<Literal>]
    let ``has-text-danger-light-invert`` = "has-text-danger-light-invert"

    [<Literal>]
    let ``has-text-danger-soft`` = "has-text-danger-soft"

    [<Literal>]
    let ``has-text-danger-soft-invert`` = "has-text-danger-soft-invert"

    [<Literal>]
    let ``has-text-danger-bold`` = "has-text-danger-bold"

    [<Literal>]
    let ``has-text-danger-bold-invert`` = "has-text-danger-bold-invert"

    [<Literal>]
    let ``has-text-danger-on-scheme`` = "has-text-danger-on-scheme"

    [<Literal>]
    let ``has-text-danger-on-scheme-invert`` = "has-text-danger-on-scheme-invert"

    [<Literal>]
    let ``has-text-danger-00`` = "has-text-danger-00"

    [<Literal>]
    let ``has-text-danger-00-invert`` = "has-text-danger-00-invert"

    [<Literal>]
    let ``has-text-danger-05`` = "has-text-danger-05"

    [<Literal>]
    let ``has-text-danger-05-invert`` = "has-text-danger-05-invert"

    [<Literal>]
    let ``has-text-danger-10`` = "has-text-danger-10"

    [<Literal>]
    let ``has-text-danger-10-invert`` = "has-text-danger-10-invert"

    [<Literal>]
    let ``has-text-danger-15`` = "has-text-danger-15"

    [<Literal>]
    let ``has-text-danger-15-invert`` = "has-text-danger-15-invert"

    [<Literal>]
    let ``has-text-danger-20`` = "has-text-danger-20"

    [<Literal>]
    let ``has-text-danger-20-invert`` = "has-text-danger-20-invert"

    [<Literal>]
    let ``has-text-danger-25`` = "has-text-danger-25"

    [<Literal>]
    let ``has-text-danger-25-invert`` = "has-text-danger-25-invert"

    [<Literal>]
    let ``has-text-danger-30`` = "has-text-danger-30"

    [<Literal>]
    let ``has-text-danger-30-invert`` = "has-text-danger-30-invert"

    [<Literal>]
    let ``has-text-danger-35`` = "has-text-danger-35"

    [<Literal>]
    let ``has-text-danger-35-invert`` = "has-text-danger-35-invert"

    [<Literal>]
    let ``has-text-danger-40`` = "has-text-danger-40"

    [<Literal>]
    let ``has-text-danger-40-invert`` = "has-text-danger-40-invert"

    [<Literal>]
    let ``has-text-danger-45`` = "has-text-danger-45"

    [<Literal>]
    let ``has-text-danger-45-invert`` = "has-text-danger-45-invert"

    [<Literal>]
    let ``has-text-danger-50`` = "has-text-danger-50"

    [<Literal>]
    let ``has-text-danger-50-invert`` = "has-text-danger-50-invert"

    [<Literal>]
    let ``has-text-danger-55`` = "has-text-danger-55"

    [<Literal>]
    let ``has-text-danger-55-invert`` = "has-text-danger-55-invert"

    [<Literal>]
    let ``has-text-danger-60`` = "has-text-danger-60"

    [<Literal>]
    let ``has-text-danger-60-invert`` = "has-text-danger-60-invert"

    [<Literal>]
    let ``has-text-danger-65`` = "has-text-danger-65"

    [<Literal>]
    let ``has-text-danger-65-invert`` = "has-text-danger-65-invert"

    [<Literal>]
    let ``has-text-danger-70`` = "has-text-danger-70"

    [<Literal>]
    let ``has-text-danger-70-invert`` = "has-text-danger-70-invert"

    [<Literal>]
    let ``has-text-danger-75`` = "has-text-danger-75"

    [<Literal>]
    let ``has-text-danger-75-invert`` = "has-text-danger-75-invert"

    [<Literal>]
    let ``has-text-danger-80`` = "has-text-danger-80"

    [<Literal>]
    let ``has-text-danger-80-invert`` = "has-text-danger-80-invert"

    [<Literal>]
    let ``has-text-danger-85`` = "has-text-danger-85"

    [<Literal>]
    let ``has-text-danger-85-invert`` = "has-text-danger-85-invert"

    [<Literal>]
    let ``has-text-danger-90`` = "has-text-danger-90"

    [<Literal>]
    let ``has-text-danger-90-invert`` = "has-text-danger-90-invert"

    [<Literal>]
    let ``has-text-danger-95`` = "has-text-danger-95"

    [<Literal>]
    let ``has-text-danger-95-invert`` = "has-text-danger-95-invert"

    [<Literal>]
    let ``has-text-danger-100`` = "has-text-danger-100"

    [<Literal>]
    let ``has-text-danger-100-invert`` = "has-text-danger-100-invert"

    [<Literal>]
    let ``has-text-black-bis`` = "has-text-black-bis"

    [<Literal>]
    let ``has-text-black-ter`` = "has-text-black-ter"

    [<Literal>]
    let ``has-text-grey-darker`` = "has-text-grey-darker"

    [<Literal>]
    let ``has-text-grey-dark`` = "has-text-grey-dark"

    [<Literal>]
    let ``has-text-grey`` = "has-text-grey"

    [<Literal>]
    let ``has-text-grey-light`` = "has-text-grey-light"

    [<Literal>]
    let ``has-text-grey-lighter`` = "has-text-grey-lighter"

    [<Literal>]
    let ``has-text-white-ter`` = "has-text-white-ter"

    [<Literal>]
    let ``has-text-white-bis`` = "has-text-white-bis"

    [<Literal>]
    let ``has-text-current`` = "has-text-current"

    [<Literal>]
    let ``has-text-inherit`` = "has-text-inherit"

    [<Literal>]
    let ``has-background-white`` = "has-background-white"

    [<Literal>]
    let ``has-background-black`` = "has-background-black"

    [<Literal>]
    let ``has-background-light`` = "has-background-light"

    [<Literal>]
    let ``has-background-dark`` = "has-background-dark"

    [<Literal>]
    let ``has-background-text`` = "has-background-text"

    [<Literal>]
    let ``has-background-primary`` = "has-background-primary"

    [<Literal>]
    let ``has-background-info`` = "has-background-info"

    [<Literal>]
    let ``has-background-link`` = "has-background-link"

    [<Literal>]
    let ``has-background-success`` = "has-background-success"

    [<Literal>]
    let ``has-background-warning`` = "has-background-warning"

    [<Literal>]
    let ``has-background-danger`` = "has-background-danger"

    [<Literal>]
    let ``has-background-black-bis`` = "has-background-black-bis"

    [<Literal>]
    let ``has-background-black-ter`` = "has-background-black-ter"

    [<Literal>]
    let ``has-background-grey-darker`` = "has-background-grey-darker"

    [<Literal>]
    let ``has-background-grey-dark`` = "has-background-grey-dark"

    [<Literal>]
    let ``has-background-grey`` = "has-background-grey"

    [<Literal>]
    let ``has-background-grey-light`` = "has-background-grey-light"

    [<Literal>]
    let ``has-background-grey-lighter`` = "has-background-grey-lighter"

    [<Literal>]
    let ``has-background-white-ter`` = "has-background-white-ter"

    [<Literal>]
    let ``has-background-white-bis`` = "has-background-white-bis"

    [<Literal>]
    let ``has-background-text-invert`` = "has-background-text-invert"

    [<Literal>]
    let ``has-background-primary-invert`` = "has-background-primary-invert"

    [<Literal>]
    let ``has-background-link-invert`` = "has-background-link-invert"

    [<Literal>]
    let ``has-background-info-invert`` = "has-background-info-invert"

    [<Literal>]
    let ``has-background-success-invert`` = "has-background-success-invert"

    [<Literal>]
    let ``has-background-warning-invert`` = "has-background-warning-invert"

    [<Literal>]
    let ``has-background-danger-invert`` = "has-background-danger-invert"

    [<Literal>]
    let ``has-background-text-light`` = "has-background-text-light"

    [<Literal>]
    let ``has-background-primary-light`` = "has-background-primary-light"

    [<Literal>]
    let ``has-background-link-light`` = "has-background-link-light"

    [<Literal>]
    let ``has-background-info-light`` = "has-background-info-light"

    [<Literal>]
    let ``has-background-success-light`` = "has-background-success-light"

    [<Literal>]
    let ``has-background-warning-light`` = "has-background-warning-light"

    [<Literal>]
    let ``has-background-danger-light`` = "has-background-danger-light"

    [<Literal>]
    let ``has-background-text-light-invert`` = "has-background-text-light-invert"

    [<Literal>]
    let ``has-background-primary-light-invert`` = "has-background-primary-light-invert"

    [<Literal>]
    let ``has-background-link-light-invert`` = "has-background-link-light-invert"

    [<Literal>]
    let ``has-background-info-light-invert`` = "has-background-info-light-invert"

    [<Literal>]
    let ``has-background-success-light-invert`` = "has-background-success-light-invert"

    [<Literal>]
    let ``has-background-warning-light-invert`` = "has-background-warning-light-invert"

    [<Literal>]
    let ``has-background-danger-light-invert`` = "has-background-danger-light-invert"

    [<Literal>]
    let ``has-background-text-dark`` = "has-background-text-dark"

    [<Literal>]
    let ``has-background-primary-dark`` = "has-background-primary-dark"

    [<Literal>]
    let ``has-background-link-dark`` = "has-background-link-dark"

    [<Literal>]
    let ``has-background-info-dark`` = "has-background-info-dark"

    [<Literal>]
    let ``has-background-success-dark`` = "has-background-success-dark"

    [<Literal>]
    let ``has-background-warning-dark`` = "has-background-warning-dark"

    [<Literal>]
    let ``has-background-danger-dark`` = "has-background-danger-dark"

    [<Literal>]
    let ``has-background-text-dark-invert`` = "has-background-text-dark-invert"

    [<Literal>]
    let ``has-background-primary-dark-invert`` = "has-background-primary-dark-invert"

    [<Literal>]
    let ``has-background-link-dark-invert`` = "has-background-link-dark-invert"

    [<Literal>]
    let ``has-background-info-dark-invert`` = "has-background-info-dark-invert"

    [<Literal>]
    let ``has-background-success-dark-invert`` = "has-background-success-dark-invert"

    [<Literal>]
    let ``has-background-warning-dark-invert`` = "has-background-warning-dark-invert"

    [<Literal>]
    let ``has-background-danger-dark-invert`` = "has-background-danger-dark-invert"

    [<Literal>]
    let ``has-background-text-soft`` = "has-background-text-soft"

    [<Literal>]
    let ``has-background-primary-soft`` = "has-background-primary-soft"

    [<Literal>]
    let ``has-background-link-soft`` = "has-background-link-soft"

    [<Literal>]
    let ``has-background-info-soft`` = "has-background-info-soft"

    [<Literal>]
    let ``has-background-success-soft`` = "has-background-success-soft"

    [<Literal>]
    let ``has-background-warning-soft`` = "has-background-warning-soft"

    [<Literal>]
    let ``has-background-danger-soft`` = "has-background-danger-soft"

    [<Literal>]
    let ``has-background-text-bold`` = "has-background-text-bold"

    [<Literal>]
    let ``has-background-primary-bold`` = "has-background-primary-bold"

    [<Literal>]
    let ``has-background-link-bold`` = "has-background-link-bold"

    [<Literal>]
    let ``has-background-info-bold`` = "has-background-info-bold"

    [<Literal>]
    let ``has-background-success-bold`` = "has-background-success-bold"

    [<Literal>]
    let ``has-background-warning-bold`` = "has-background-warning-bold"

    [<Literal>]
    let ``has-background-danger-bold`` = "has-background-danger-bold"

    [<Literal>]
    let ``has-background-text-on-scheme`` = "has-background-text-on-scheme"

    [<Literal>]
    let ``has-background-primary-on-scheme`` = "has-background-primary-on-scheme"

    [<Literal>]
    let ``has-background-link-on-scheme`` = "has-background-link-on-scheme"

    [<Literal>]
    let ``has-background-info-on-scheme`` = "has-background-info-on-scheme"

    [<Literal>]
    let ``has-background-success-on-scheme`` = "has-background-success-on-scheme"

    [<Literal>]
    let ``has-background-warning-on-scheme`` = "has-background-warning-on-scheme"

    [<Literal>]
    let ``has-background-danger-on-scheme`` = "has-background-danger-on-scheme"

    [<Literal>]
    let ``has-background-text-00`` = "has-background-text-00"

    [<Literal>]
    let ``has-background-primary-00`` = "has-background-primary-00"

    [<Literal>]
    let ``has-background-link-00`` = "has-background-link-00"

    [<Literal>]
    let ``has-background-info-00`` = "has-background-info-00"

    [<Literal>]
    let ``has-background-success-00`` = "has-background-success-00"

    [<Literal>]
    let ``has-background-warning-00`` = "has-background-warning-00"

    [<Literal>]
    let ``has-background-danger-00`` = "has-background-danger-00"

    [<Literal>]
    let ``has-background-text-05`` = "has-background-text-05"

    [<Literal>]
    let ``has-background-primary-05`` = "has-background-primary-05"

    [<Literal>]
    let ``has-background-link-05`` = "has-background-link-05"

    [<Literal>]
    let ``has-background-info-05`` = "has-background-info-05"

    [<Literal>]
    let ``has-background-success-05`` = "has-background-success-05"

    [<Literal>]
    let ``has-background-warning-05`` = "has-background-warning-05"

    [<Literal>]
    let ``has-background-danger-05`` = "has-background-danger-05"

    [<Literal>]
    let ``has-background-text-10`` = "has-background-text-10"

    [<Literal>]
    let ``has-background-primary-10`` = "has-background-primary-10"

    [<Literal>]
    let ``has-background-link-10`` = "has-background-link-10"

    [<Literal>]
    let ``has-background-info-10`` = "has-background-info-10"

    [<Literal>]
    let ``has-background-success-10`` = "has-background-success-10"

    [<Literal>]
    let ``has-background-warning-10`` = "has-background-warning-10"

    [<Literal>]
    let ``has-background-danger-10`` = "has-background-danger-10"

    [<Literal>]
    let ``has-background-text-15`` = "has-background-text-15"

    [<Literal>]
    let ``has-background-primary-15`` = "has-background-primary-15"

    [<Literal>]
    let ``has-background-link-15`` = "has-background-link-15"

    [<Literal>]
    let ``has-background-info-15`` = "has-background-info-15"

    [<Literal>]
    let ``has-background-success-15`` = "has-background-success-15"

    [<Literal>]
    let ``has-background-warning-15`` = "has-background-warning-15"

    [<Literal>]
    let ``has-background-danger-15`` = "has-background-danger-15"

    [<Literal>]
    let ``has-background-text-20`` = "has-background-text-20"

    [<Literal>]
    let ``has-background-primary-20`` = "has-background-primary-20"

    [<Literal>]
    let ``has-background-link-20`` = "has-background-link-20"

    [<Literal>]
    let ``has-background-info-20`` = "has-background-info-20"

    [<Literal>]
    let ``has-background-success-20`` = "has-background-success-20"

    [<Literal>]
    let ``has-background-warning-20`` = "has-background-warning-20"

    [<Literal>]
    let ``has-background-danger-20`` = "has-background-danger-20"

    [<Literal>]
    let ``has-background-text-25`` = "has-background-text-25"

    [<Literal>]
    let ``has-background-primary-25`` = "has-background-primary-25"

    [<Literal>]
    let ``has-background-link-25`` = "has-background-link-25"

    [<Literal>]
    let ``has-background-info-25`` = "has-background-info-25"

    [<Literal>]
    let ``has-background-success-25`` = "has-background-success-25"

    [<Literal>]
    let ``has-background-warning-25`` = "has-background-warning-25"

    [<Literal>]
    let ``has-background-danger-25`` = "has-background-danger-25"

    [<Literal>]
    let ``has-background-text-30`` = "has-background-text-30"

    [<Literal>]
    let ``has-background-primary-30`` = "has-background-primary-30"

    [<Literal>]
    let ``has-background-link-30`` = "has-background-link-30"

    [<Literal>]
    let ``has-background-info-30`` = "has-background-info-30"

    [<Literal>]
    let ``has-background-success-30`` = "has-background-success-30"

    [<Literal>]
    let ``has-background-warning-30`` = "has-background-warning-30"

    [<Literal>]
    let ``has-background-danger-30`` = "has-background-danger-30"

    [<Literal>]
    let ``has-background-text-35`` = "has-background-text-35"

    [<Literal>]
    let ``has-background-primary-35`` = "has-background-primary-35"

    [<Literal>]
    let ``has-background-link-35`` = "has-background-link-35"

    [<Literal>]
    let ``has-background-info-35`` = "has-background-info-35"

    [<Literal>]
    let ``has-background-success-35`` = "has-background-success-35"

    [<Literal>]
    let ``has-background-warning-35`` = "has-background-warning-35"

    [<Literal>]
    let ``has-background-danger-35`` = "has-background-danger-35"

    [<Literal>]
    let ``has-background-text-40`` = "has-background-text-40"

    [<Literal>]
    let ``has-background-primary-40`` = "has-background-primary-40"

    [<Literal>]
    let ``has-background-link-40`` = "has-background-link-40"

    [<Literal>]
    let ``has-background-info-40`` = "has-background-info-40"

    [<Literal>]
    let ``has-background-success-40`` = "has-background-success-40"

    [<Literal>]
    let ``has-background-warning-40`` = "has-background-warning-40"

    [<Literal>]
    let ``has-background-danger-40`` = "has-background-danger-40"

    [<Literal>]
    let ``has-background-text-45`` = "has-background-text-45"

    [<Literal>]
    let ``has-background-primary-45`` = "has-background-primary-45"

    [<Literal>]
    let ``has-background-link-45`` = "has-background-link-45"

    [<Literal>]
    let ``has-background-info-45`` = "has-background-info-45"

    [<Literal>]
    let ``has-background-success-45`` = "has-background-success-45"

    [<Literal>]
    let ``has-background-warning-45`` = "has-background-warning-45"

    [<Literal>]
    let ``has-background-danger-45`` = "has-background-danger-45"

    [<Literal>]
    let ``has-background-text-50`` = "has-background-text-50"

    [<Literal>]
    let ``has-background-primary-50`` = "has-background-primary-50"

    [<Literal>]
    let ``has-background-link-50`` = "has-background-link-50"

    [<Literal>]
    let ``has-background-info-50`` = "has-background-info-50"

    [<Literal>]
    let ``has-background-success-50`` = "has-background-success-50"

    [<Literal>]
    let ``has-background-warning-50`` = "has-background-warning-50"

    [<Literal>]
    let ``has-background-danger-50`` = "has-background-danger-50"

    [<Literal>]
    let ``has-background-text-55`` = "has-background-text-55"

    [<Literal>]
    let ``has-background-primary-55`` = "has-background-primary-55"

    [<Literal>]
    let ``has-background-link-55`` = "has-background-link-55"

    [<Literal>]
    let ``has-background-info-55`` = "has-background-info-55"

    [<Literal>]
    let ``has-background-success-55`` = "has-background-success-55"

    [<Literal>]
    let ``has-background-warning-55`` = "has-background-warning-55"

    [<Literal>]
    let ``has-background-danger-55`` = "has-background-danger-55"

    [<Literal>]
    let ``has-background-text-60`` = "has-background-text-60"

    [<Literal>]
    let ``has-background-primary-60`` = "has-background-primary-60"

    [<Literal>]
    let ``has-background-link-60`` = "has-background-link-60"

    [<Literal>]
    let ``has-background-info-60`` = "has-background-info-60"

    [<Literal>]
    let ``has-background-success-60`` = "has-background-success-60"

    [<Literal>]
    let ``has-background-warning-60`` = "has-background-warning-60"

    [<Literal>]
    let ``has-background-danger-60`` = "has-background-danger-60"

    [<Literal>]
    let ``has-background-text-65`` = "has-background-text-65"

    [<Literal>]
    let ``has-background-primary-65`` = "has-background-primary-65"

    [<Literal>]
    let ``has-background-link-65`` = "has-background-link-65"

    [<Literal>]
    let ``has-background-info-65`` = "has-background-info-65"

    [<Literal>]
    let ``has-background-success-65`` = "has-background-success-65"

    [<Literal>]
    let ``has-background-warning-65`` = "has-background-warning-65"

    [<Literal>]
    let ``has-background-danger-65`` = "has-background-danger-65"

    [<Literal>]
    let ``has-background-text-70`` = "has-background-text-70"

    [<Literal>]
    let ``has-background-primary-70`` = "has-background-primary-70"

    [<Literal>]
    let ``has-background-link-70`` = "has-background-link-70"

    [<Literal>]
    let ``has-background-info-70`` = "has-background-info-70"

    [<Literal>]
    let ``has-background-success-70`` = "has-background-success-70"

    [<Literal>]
    let ``has-background-warning-70`` = "has-background-warning-70"

    [<Literal>]
    let ``has-background-danger-70`` = "has-background-danger-70"

    [<Literal>]
    let ``has-background-text-75`` = "has-background-text-75"

    [<Literal>]
    let ``has-background-primary-75`` = "has-background-primary-75"

    [<Literal>]
    let ``has-background-link-75`` = "has-background-link-75"

    [<Literal>]
    let ``has-background-info-75`` = "has-background-info-75"

    [<Literal>]
    let ``has-background-success-75`` = "has-background-success-75"

    [<Literal>]
    let ``has-background-warning-75`` = "has-background-warning-75"

    [<Literal>]
    let ``has-background-danger-75`` = "has-background-danger-75"

    [<Literal>]
    let ``has-background-text-80`` = "has-background-text-80"

    [<Literal>]
    let ``has-background-primary-80`` = "has-background-primary-80"

    [<Literal>]
    let ``has-background-link-80`` = "has-background-link-80"

    [<Literal>]
    let ``has-background-info-80`` = "has-background-info-80"

    [<Literal>]
    let ``has-background-success-80`` = "has-background-success-80"

    [<Literal>]
    let ``has-background-warning-80`` = "has-background-warning-80"

    [<Literal>]
    let ``has-background-danger-80`` = "has-background-danger-80"

    [<Literal>]
    let ``has-background-text-85`` = "has-background-text-85"

    [<Literal>]
    let ``has-background-primary-85`` = "has-background-primary-85"

    [<Literal>]
    let ``has-background-link-85`` = "has-background-link-85"

    [<Literal>]
    let ``has-background-info-85`` = "has-background-info-85"

    [<Literal>]
    let ``has-background-success-85`` = "has-background-success-85"

    [<Literal>]
    let ``has-background-warning-85`` = "has-background-warning-85"

    [<Literal>]
    let ``has-background-danger-85`` = "has-background-danger-85"

    [<Literal>]
    let ``has-background-text-90`` = "has-background-text-90"

    [<Literal>]
    let ``has-background-primary-90`` = "has-background-primary-90"

    [<Literal>]
    let ``has-background-link-90`` = "has-background-link-90"

    [<Literal>]
    let ``has-background-info-90`` = "has-background-info-90"

    [<Literal>]
    let ``has-background-success-90`` = "has-background-success-90"

    [<Literal>]
    let ``has-background-warning-90`` = "has-background-warning-90"

    [<Literal>]
    let ``has-background-danger-90`` = "has-background-danger-90"

    [<Literal>]
    let ``has-background-text-95`` = "has-background-text-95"

    [<Literal>]
    let ``has-background-primary-95`` = "has-background-primary-95"

    [<Literal>]
    let ``has-background-link-95`` = "has-background-link-95"

    [<Literal>]
    let ``has-background-info-95`` = "has-background-info-95"

    [<Literal>]
    let ``has-background-success-95`` = "has-background-success-95"

    [<Literal>]
    let ``has-background-warning-95`` = "has-background-warning-95"

    [<Literal>]
    let ``has-background-danger-95`` = "has-background-danger-95"

    [<Literal>]
    let ``has-background-text-100`` = "has-background-text-100"

    [<Literal>]
    let ``has-background-primary-100`` = "has-background-primary-100"

    [<Literal>]
    let ``has-background-link-100`` = "has-background-link-100"

    [<Literal>]
    let ``has-background-info-100`` = "has-background-info-100"

    [<Literal>]
    let ``has-background-success-100`` = "has-background-success-100"

    [<Literal>]
    let ``has-background-warning-100`` = "has-background-warning-100"

    [<Literal>]
    let ``has-background-danger-100`` = "has-background-danger-100"

    [<Literal>]
    let ``has-background-current`` = "has-background-current"

    [<Literal>]
    let ``has-background-inherit`` = "has-background-inherit"

    [<Literal>]
    let ``is-16x16`` = "is-16x16"

    [<Literal>]
    let ``is-24x24`` = "is-24x24"

    [<Literal>]
    let ``is-32x32`` = "is-32x32"

    [<Literal>]
    let ``is-48x48`` = "is-48x48"

    [<Literal>]
    let ``is-64x64`` = "is-64x64"

    [<Literal>]
    let ``is-96x96`` = "is-96x96"

    [<Literal>]
    let ``is-128x128`` = "is-128x128"

    [<Literal>]
    let ``is-rounded`` = "is-rounded"

    [<Literal>]
    let ``is-square`` = "is-square"

    [<Literal>]
    let ``is-1by1`` = "is-1by1"

    [<Literal>]
    let ``is-5by4`` = "is-5by4"

    [<Literal>]
    let ``is-4by3`` = "is-4by3"

    [<Literal>]
    let ``is-3by2`` = "is-3by2"

    [<Literal>]
    let ``is-5by3`` = "is-5by3"

    [<Literal>]
    let ``is-16by9`` = "is-16by9"

    [<Literal>]
    let ``is-2by1`` = "is-2by1"

    [<Literal>]
    let ``is-3by1`` = "is-3by1"

    [<Literal>]
    let ``is-4by5`` = "is-4by5"

    [<Literal>]
    let ``is-3by4`` = "is-3by4"

    [<Literal>]
    let ``is-2by3`` = "is-2by3"

    [<Literal>]
    let ``is-3by5`` = "is-3by5"

    [<Literal>]
    let ``is-9by16`` = "is-9by16"

    [<Literal>]
    let ``is-1by2`` = "is-1by2"

    [<Literal>]
    let ``is-1by3`` = "is-1by3"

    [<Literal>]
    let ``is-fullwidth`` = "is-fullwidth"

    [<Literal>]
    let ``has-ratio`` = "has-ratio"

    [<Literal>]
    let ``is-bordered`` = "is-bordered"

    [<Literal>]
    let ``is-striped`` = "is-striped"

    [<Literal>]
    let ``is-narrow`` = "is-narrow"

    [<Literal>]
    let ``is-hoverable`` = "is-hoverable"

    [<Literal>]
    let ``is-selected`` = "is-selected"

    [<Literal>]
    let ``is-normal`` = "is-normal"

    [<Literal>]
    let ``is-medium`` = "is-medium"

    [<Literal>]
    let ``is-large`` = "is-large"

    [<Literal>]
    let ``is-delete`` = "is-delete"

    [<Literal>]
    let ``are-small`` = "are-small"

    [<Literal>]
    let ``are-medium`` = "are-medium"

    [<Literal>]
    let ``are-large`` = "are-large"

    [<Literal>]
    let ``has-addons`` = "has-addons"

    [<Literal>]
    let ``is-spaced`` = "is-spaced"

    [<Literal>]
    let ``is-centered`` = "is-centered"

    [<Literal>]
    let ``is-right`` = "is-right"

    [<Literal>]
    let ``is-small`` = "is-small"

    [<Literal>]
    let ``is-boxed`` = "is-boxed"

    [<Literal>]
    let ``is-toggle`` = "is-toggle"

    [<Literal>]
    let ``is-toggle-rounded`` = "is-toggle-rounded"

    [<Literal>]
    let ``has-arrow-separator`` = "has-arrow-separator"

    [<Literal>]
    let ``has-bullet-separator`` = "has-bullet-separator"

    [<Literal>]
    let ``has-dot-separator`` = "has-dot-separator"

    [<Literal>]
    let ``has-succeeds-separator`` = "has-succeeds-separator"

    [<Literal>]
    let ``is-active`` = "is-active"

    [<Literal>]
    let ``is-skeleton`` = "is-skeleton"

    [<Literal>]
    let ``has-skeleton`` = "has-skeleton"

    [<Literal>]
    let ``is-up`` = "is-up"

    [<Literal>]
    let ``is-transparent`` = "is-transparent"

    [<Literal>]
    let ``has-shadow`` = "has-shadow"

    [<Literal>]
    let ``is-fixed-top`` = "is-fixed-top"

    [<Literal>]
    let ``is-fixed-bottom`` = "is-fixed-bottom"

    [<Literal>]
    let ``is-arrowless`` = "is-arrowless"

    [<Literal>]
    let ``is-expanded`` = "is-expanded"

    [<Literal>]
    let ``is-tab`` = "is-tab"

    [<Literal>]
    let ``has-dropdown`` = "has-dropdown"

    [<Literal>]
    let ``has-dropdown-up`` = "has-dropdown-up"

    [<Literal>]
    let ``is-current`` = "is-current"

    [<Literal>]
    let ``has-name`` = "has-name"

    [<Literal>]
    let ``is-hovered`` = "is-hovered"

    [<Literal>]
    let ``is-focused`` = "is-focused"

    [<Literal>]
    let ``is-static`` = "is-static"

    [<Literal>]
    let ``is-outlined`` = "is-outlined"

    [<Literal>]
    let ``is-loading`` = "is-loading"

    [<Literal>]
    let ``is-inverted`` = "is-inverted"

    [<Literal>]
    let ``has-fixed-size`` = "has-fixed-size"

    [<Literal>]
    let ``has-addons-right`` = "has-addons-right"

    [<Literal>]
    let ``has-addons-centered`` = "has-addons-centered"

    [<Literal>]
    let ``is-grouped`` = "is-grouped"

    [<Literal>]
    let ``is-grouped-right`` = "is-grouped-right"

    [<Literal>]
    let ``is-grouped-centered`` = "is-grouped-centered"

    [<Literal>]
    let ``is-grouped-multiline`` = "is-grouped-multiline"

    [<Literal>]
    let ``is-horizontal`` = "is-horizontal"

    [<Literal>]
    let ``is-left`` = "is-left"

    [<Literal>]
    let ``is-multiple`` = "is-multiple"

    [<Literal>]
    let ``has-icons-left`` = "has-icons-left"

    [<Literal>]
    let ``has-icons-right`` = "has-icons-right"

    [<Literal>]
    let ``is-lower-alpha`` = "is-lower-alpha"

    [<Literal>]
    let ``is-lower-roman`` = "is-lower-roman"

    [<Literal>]
    let ``is-upper-alpha`` = "is-upper-alpha"

    [<Literal>]
    let ``is-upper-roman`` = "is-upper-roman"

    [<Literal>]
    let ``is-fluid`` = "is-fluid"

    [<Literal>]
    let ``is-widescreen`` = "is-widescreen"

    [<Literal>]
    let ``is-fullhd`` = "is-fullhd"

    [<Literal>]
    let ``is-max-desktop`` = "is-max-desktop"

    [<Literal>]
    let ``is-max-widescreen`` = "is-max-widescreen"

    [<Literal>]
    let ``is-mobile`` = "is-mobile"

    [<Literal>]
    let ``is-desktop`` = "is-desktop"

    [<Literal>]
    let ``is-bold`` = "is-bold"

    [<Literal>]
    let ``is-fullheight`` = "is-fullheight"

    [<Literal>]
    let ``is-fullheight-with-navbar`` = "is-fullheight-with-navbar"

    [<Literal>]
    let ``is-1`` = "is-1"

    [<Literal>]
    let ``is-1-mobile`` = "is-1-mobile"

    [<Literal>]
    let ``is-1-tablet`` = "is-1-tablet"

    [<Literal>]
    let ``is-1-tablet-only`` = "is-1-tablet-only"

    [<Literal>]
    let ``is-1-touch`` = "is-1-touch"

    [<Literal>]
    let ``is-1-desktop`` = "is-1-desktop"

    [<Literal>]
    let ``is-1-desktop-only`` = "is-1-desktop-only"

    [<Literal>]
    let ``is-1-widescreen`` = "is-1-widescreen"

    [<Literal>]
    let ``is-1-widescreen-only`` = "is-1-widescreen-only"

    [<Literal>]
    let ``is-1-fullhd`` = "is-1-fullhd"

    [<Literal>]
    let ``is-2`` = "is-2"

    [<Literal>]
    let ``is-2-mobile`` = "is-2-mobile"

    [<Literal>]
    let ``is-2-tablet`` = "is-2-tablet"

    [<Literal>]
    let ``is-2-tablet-only`` = "is-2-tablet-only"

    [<Literal>]
    let ``is-2-touch`` = "is-2-touch"

    [<Literal>]
    let ``is-2-desktop`` = "is-2-desktop"

    [<Literal>]
    let ``is-2-desktop-only`` = "is-2-desktop-only"

    [<Literal>]
    let ``is-2-widescreen`` = "is-2-widescreen"

    [<Literal>]
    let ``is-2-widescreen-only`` = "is-2-widescreen-only"

    [<Literal>]
    let ``is-2-fullhd`` = "is-2-fullhd"

    [<Literal>]
    let ``is-3`` = "is-3"

    [<Literal>]
    let ``is-3-mobile`` = "is-3-mobile"

    [<Literal>]
    let ``is-3-tablet`` = "is-3-tablet"

    [<Literal>]
    let ``is-3-tablet-only`` = "is-3-tablet-only"

    [<Literal>]
    let ``is-3-touch`` = "is-3-touch"

    [<Literal>]
    let ``is-3-desktop`` = "is-3-desktop"

    [<Literal>]
    let ``is-3-desktop-only`` = "is-3-desktop-only"

    [<Literal>]
    let ``is-3-widescreen`` = "is-3-widescreen"

    [<Literal>]
    let ``is-3-widescreen-only`` = "is-3-widescreen-only"

    [<Literal>]
    let ``is-3-fullhd`` = "is-3-fullhd"

    [<Literal>]
    let ``is-4`` = "is-4"

    [<Literal>]
    let ``is-4-mobile`` = "is-4-mobile"

    [<Literal>]
    let ``is-4-tablet`` = "is-4-tablet"

    [<Literal>]
    let ``is-4-tablet-only`` = "is-4-tablet-only"

    [<Literal>]
    let ``is-4-touch`` = "is-4-touch"

    [<Literal>]
    let ``is-4-desktop`` = "is-4-desktop"

    [<Literal>]
    let ``is-4-desktop-only`` = "is-4-desktop-only"

    [<Literal>]
    let ``is-4-widescreen`` = "is-4-widescreen"

    [<Literal>]
    let ``is-4-widescreen-only`` = "is-4-widescreen-only"

    [<Literal>]
    let ``is-4-fullhd`` = "is-4-fullhd"

    [<Literal>]
    let ``is-5`` = "is-5"

    [<Literal>]
    let ``is-5-mobile`` = "is-5-mobile"

    [<Literal>]
    let ``is-5-tablet`` = "is-5-tablet"

    [<Literal>]
    let ``is-5-tablet-only`` = "is-5-tablet-only"

    [<Literal>]
    let ``is-5-touch`` = "is-5-touch"

    [<Literal>]
    let ``is-5-desktop`` = "is-5-desktop"

    [<Literal>]
    let ``is-5-desktop-only`` = "is-5-desktop-only"

    [<Literal>]
    let ``is-5-widescreen`` = "is-5-widescreen"

    [<Literal>]
    let ``is-5-widescreen-only`` = "is-5-widescreen-only"

    [<Literal>]
    let ``is-5-fullhd`` = "is-5-fullhd"

    [<Literal>]
    let ``is-6`` = "is-6"

    [<Literal>]
    let ``is-6-mobile`` = "is-6-mobile"

    [<Literal>]
    let ``is-6-tablet`` = "is-6-tablet"

    [<Literal>]
    let ``is-6-tablet-only`` = "is-6-tablet-only"

    [<Literal>]
    let ``is-6-touch`` = "is-6-touch"

    [<Literal>]
    let ``is-6-desktop`` = "is-6-desktop"

    [<Literal>]
    let ``is-6-desktop-only`` = "is-6-desktop-only"

    [<Literal>]
    let ``is-6-widescreen`` = "is-6-widescreen"

    [<Literal>]
    let ``is-6-widescreen-only`` = "is-6-widescreen-only"

    [<Literal>]
    let ``is-6-fullhd`` = "is-6-fullhd"

    [<Literal>]
    let ``is-7`` = "is-7"

    [<Literal>]
    let ``is-7-mobile`` = "is-7-mobile"

    [<Literal>]
    let ``is-7-tablet`` = "is-7-tablet"

    [<Literal>]
    let ``is-7-tablet-only`` = "is-7-tablet-only"

    [<Literal>]
    let ``is-7-touch`` = "is-7-touch"

    [<Literal>]
    let ``is-7-desktop`` = "is-7-desktop"

    [<Literal>]
    let ``is-7-desktop-only`` = "is-7-desktop-only"

    [<Literal>]
    let ``is-7-widescreen`` = "is-7-widescreen"

    [<Literal>]
    let ``is-7-widescreen-only`` = "is-7-widescreen-only"

    [<Literal>]
    let ``is-7-fullhd`` = "is-7-fullhd"

    [<Literal>]
    let ``is-8`` = "is-8"

    [<Literal>]
    let ``is-8-mobile`` = "is-8-mobile"

    [<Literal>]
    let ``is-8-tablet`` = "is-8-tablet"

    [<Literal>]
    let ``is-8-tablet-only`` = "is-8-tablet-only"

    [<Literal>]
    let ``is-8-touch`` = "is-8-touch"

    [<Literal>]
    let ``is-8-desktop`` = "is-8-desktop"

    [<Literal>]
    let ``is-8-desktop-only`` = "is-8-desktop-only"

    [<Literal>]
    let ``is-8-widescreen`` = "is-8-widescreen"

    [<Literal>]
    let ``is-8-widescreen-only`` = "is-8-widescreen-only"

    [<Literal>]
    let ``is-8-fullhd`` = "is-8-fullhd"

    [<Literal>]
    let ``is-9`` = "is-9"

    [<Literal>]
    let ``is-9-mobile`` = "is-9-mobile"

    [<Literal>]
    let ``is-9-tablet`` = "is-9-tablet"

    [<Literal>]
    let ``is-9-tablet-only`` = "is-9-tablet-only"

    [<Literal>]
    let ``is-9-touch`` = "is-9-touch"

    [<Literal>]
    let ``is-9-desktop`` = "is-9-desktop"

    [<Literal>]
    let ``is-9-desktop-only`` = "is-9-desktop-only"

    [<Literal>]
    let ``is-9-widescreen`` = "is-9-widescreen"

    [<Literal>]
    let ``is-9-widescreen-only`` = "is-9-widescreen-only"

    [<Literal>]
    let ``is-9-fullhd`` = "is-9-fullhd"

    [<Literal>]
    let ``is-10`` = "is-10"

    [<Literal>]
    let ``is-10-mobile`` = "is-10-mobile"

    [<Literal>]
    let ``is-10-tablet`` = "is-10-tablet"

    [<Literal>]
    let ``is-10-tablet-only`` = "is-10-tablet-only"

    [<Literal>]
    let ``is-10-touch`` = "is-10-touch"

    [<Literal>]
    let ``is-10-desktop`` = "is-10-desktop"

    [<Literal>]
    let ``is-10-desktop-only`` = "is-10-desktop-only"

    [<Literal>]
    let ``is-10-widescreen`` = "is-10-widescreen"

    [<Literal>]
    let ``is-10-widescreen-only`` = "is-10-widescreen-only"

    [<Literal>]
    let ``is-10-fullhd`` = "is-10-fullhd"

    [<Literal>]
    let ``is-11`` = "is-11"

    [<Literal>]
    let ``is-11-mobile`` = "is-11-mobile"

    [<Literal>]
    let ``is-11-tablet`` = "is-11-tablet"

    [<Literal>]
    let ``is-11-tablet-only`` = "is-11-tablet-only"

    [<Literal>]
    let ``is-11-touch`` = "is-11-touch"

    [<Literal>]
    let ``is-11-desktop`` = "is-11-desktop"

    [<Literal>]
    let ``is-11-desktop-only`` = "is-11-desktop-only"

    [<Literal>]
    let ``is-11-widescreen`` = "is-11-widescreen"

    [<Literal>]
    let ``is-11-widescreen-only`` = "is-11-widescreen-only"

    [<Literal>]
    let ``is-11-fullhd`` = "is-11-fullhd"

    [<Literal>]
    let ``is-12`` = "is-12"

    [<Literal>]
    let ``is-12-mobile`` = "is-12-mobile"

    [<Literal>]
    let ``is-12-tablet`` = "is-12-tablet"

    [<Literal>]
    let ``is-12-tablet-only`` = "is-12-tablet-only"

    [<Literal>]
    let ``is-12-touch`` = "is-12-touch"

    [<Literal>]
    let ``is-12-desktop`` = "is-12-desktop"

    [<Literal>]
    let ``is-12-desktop-only`` = "is-12-desktop-only"

    [<Literal>]
    let ``is-12-widescreen`` = "is-12-widescreen"

    [<Literal>]
    let ``is-12-widescreen-only`` = "is-12-widescreen-only"

    [<Literal>]
    let ``is-12-fullhd`` = "is-12-fullhd"

    [<Literal>]
    let ``is-three-quarters`` = "is-three-quarters"

    [<Literal>]
    let ``is-three-quarters-mobile`` = "is-three-quarters-mobile"

    [<Literal>]
    let ``is-three-quarters-tablet`` = "is-three-quarters-tablet"

    [<Literal>]
    let ``is-three-quarters-touch`` = "is-three-quarters-touch"

    [<Literal>]
    let ``is-three-quarters-desktop`` = "is-three-quarters-desktop"

    [<Literal>]
    let ``is-three-quarters-widescreen`` = "is-three-quarters-widescreen"

    [<Literal>]
    let ``is-three-quarters-fullhd`` = "is-three-quarters-fullhd"

    [<Literal>]
    let ``is-two-thirds`` = "is-two-thirds"

    [<Literal>]
    let ``is-two-thirds-mobile`` = "is-two-thirds-mobile"

    [<Literal>]
    let ``is-two-thirds-tablet`` = "is-two-thirds-tablet"

    [<Literal>]
    let ``is-two-thirds-touch`` = "is-two-thirds-touch"

    [<Literal>]
    let ``is-two-thirds-desktop`` = "is-two-thirds-desktop"

    [<Literal>]
    let ``is-two-thirds-widescreen`` = "is-two-thirds-widescreen"

    [<Literal>]
    let ``is-two-thirds-fullhd`` = "is-two-thirds-fullhd"

    [<Literal>]
    let ``is-half`` = "is-half"

    [<Literal>]
    let ``is-half-mobile`` = "is-half-mobile"

    [<Literal>]
    let ``is-half-tablet`` = "is-half-tablet"

    [<Literal>]
    let ``is-half-touch`` = "is-half-touch"

    [<Literal>]
    let ``is-half-desktop`` = "is-half-desktop"

    [<Literal>]
    let ``is-half-widescreen`` = "is-half-widescreen"

    [<Literal>]
    let ``is-half-fullhd`` = "is-half-fullhd"

    [<Literal>]
    let ``is-one-third`` = "is-one-third"

    [<Literal>]
    let ``is-one-third-mobile`` = "is-one-third-mobile"

    [<Literal>]
    let ``is-one-third-tablet`` = "is-one-third-tablet"

    [<Literal>]
    let ``is-one-third-touch`` = "is-one-third-touch"

    [<Literal>]
    let ``is-one-third-desktop`` = "is-one-third-desktop"

    [<Literal>]
    let ``is-one-third-widescreen`` = "is-one-third-widescreen"

    [<Literal>]
    let ``is-one-third-fullhd`` = "is-one-third-fullhd"

    [<Literal>]
    let ``is-one-quarter`` = "is-one-quarter"

    [<Literal>]
    let ``is-one-quarter-mobile`` = "is-one-quarter-mobile"

    [<Literal>]
    let ``is-one-quarter-tablet`` = "is-one-quarter-tablet"

    [<Literal>]
    let ``is-one-quarter-touch`` = "is-one-quarter-touch"

    [<Literal>]
    let ``is-one-quarter-desktop`` = "is-one-quarter-desktop"

    [<Literal>]
    let ``is-one-quarter-widescreen`` = "is-one-quarter-widescreen"

    [<Literal>]
    let ``is-one-quarter-fullhd`` = "is-one-quarter-fullhd"

    [<Literal>]
    let ``is-full`` = "is-full"

    [<Literal>]
    let ``is-full-mobile`` = "is-full-mobile"

    [<Literal>]
    let ``is-full-tablet`` = "is-full-tablet"

    [<Literal>]
    let ``is-full-touch`` = "is-full-touch"

    [<Literal>]
    let ``is-full-desktop`` = "is-full-desktop"

    [<Literal>]
    let ``is-full-widescreen`` = "is-full-widescreen"

    [<Literal>]
    let ``is-full-fullhd`` = "is-full-fullhd"

    [<Literal>]
    let ``is-four-fifths`` = "is-four-fifths"

    [<Literal>]
    let ``is-four-fifths-mobile`` = "is-four-fifths-mobile"

    [<Literal>]
    let ``is-four-fifths-tablet`` = "is-four-fifths-tablet"

    [<Literal>]
    let ``is-four-fifths-touch`` = "is-four-fifths-touch"

    [<Literal>]
    let ``is-four-fifths-desktop`` = "is-four-fifths-desktop"

    [<Literal>]
    let ``is-four-fifths-widescreen`` = "is-four-fifths-widescreen"

    [<Literal>]
    let ``is-four-fifths-fullhd`` = "is-four-fifths-fullhd"

    [<Literal>]
    let ``is-three-fifths`` = "is-three-fifths"

    [<Literal>]
    let ``is-three-fifths-mobile`` = "is-three-fifths-mobile"

    [<Literal>]
    let ``is-three-fifths-tablet`` = "is-three-fifths-tablet"

    [<Literal>]
    let ``is-three-fifths-touch`` = "is-three-fifths-touch"

    [<Literal>]
    let ``is-three-fifths-desktop`` = "is-three-fifths-desktop"

    [<Literal>]
    let ``is-three-fifths-widescreen`` = "is-three-fifths-widescreen"

    [<Literal>]
    let ``is-three-fifths-fullhd`` = "is-three-fifths-fullhd"

    [<Literal>]
    let ``is-two-fifths`` = "is-two-fifths"

    [<Literal>]
    let ``is-two-fifths-mobile`` = "is-two-fifths-mobile"

    [<Literal>]
    let ``is-two-fifths-tablet`` = "is-two-fifths-tablet"

    [<Literal>]
    let ``is-two-fifths-touch`` = "is-two-fifths-touch"

    [<Literal>]
    let ``is-two-fifths-desktop`` = "is-two-fifths-desktop"

    [<Literal>]
    let ``is-two-fifths-widescreen`` = "is-two-fifths-widescreen"

    [<Literal>]
    let ``is-two-fifths-fullhd`` = "is-two-fifths-fullhd"

    [<Literal>]
    let ``is-one-fifth`` = "is-one-fifth"

    [<Literal>]
    let ``is-one-fifth-mobile`` = "is-one-fifth-mobile"

    [<Literal>]
    let ``is-one-fifth-tablet`` = "is-one-fifth-tablet"

    [<Literal>]
    let ``is-one-fifth-touch`` = "is-one-fifth-touch"

    [<Literal>]
    let ``is-one-fifth-desktop`` = "is-one-fifth-desktop"

    [<Literal>]
    let ``is-one-fifth-widescreen`` = "is-one-fifth-widescreen"

    [<Literal>]
    let ``is-one-fifth-fullhd`` = "is-one-fifth-fullhd"

    [<Literal>]
    let ``is-narrow-mobile`` = "is-narrow-mobile"

    [<Literal>]
    let ``is-narrow-tablet`` = "is-narrow-tablet"

    [<Literal>]
    let ``is-narrow-touch`` = "is-narrow-touch"

    [<Literal>]
    let ``is-narrow-desktop`` = "is-narrow-desktop"

    [<Literal>]
    let ``is-narrow-widescreen`` = "is-narrow-widescreen"

    [<Literal>]
    let ``is-narrow-fullhd`` = "is-narrow-fullhd"

    [<Literal>]
    let ``is-offset-1`` = "is-offset-1"

    [<Literal>]
    let ``is-offset-1-mobile`` = "is-offset-1-mobile"

    [<Literal>]
    let ``is-offset-1-tablet`` = "is-offset-1-tablet"

    [<Literal>]
    let ``is-offset-1-touch`` = "is-offset-1-touch"

    [<Literal>]
    let ``is-offset-1-desktop`` = "is-offset-1-desktop"

    [<Literal>]
    let ``is-offset-1-widescreen`` = "is-offset-1-widescreen"

    [<Literal>]
    let ``is-offset-1-fullhd`` = "is-offset-1-fullhd"

    [<Literal>]
    let ``is-offset-2`` = "is-offset-2"

    [<Literal>]
    let ``is-offset-2-mobile`` = "is-offset-2-mobile"

    [<Literal>]
    let ``is-offset-2-tablet`` = "is-offset-2-tablet"

    [<Literal>]
    let ``is-offset-2-touch`` = "is-offset-2-touch"

    [<Literal>]
    let ``is-offset-2-desktop`` = "is-offset-2-desktop"

    [<Literal>]
    let ``is-offset-2-widescreen`` = "is-offset-2-widescreen"

    [<Literal>]
    let ``is-offset-2-fullhd`` = "is-offset-2-fullhd"

    [<Literal>]
    let ``is-offset-3`` = "is-offset-3"

    [<Literal>]
    let ``is-offset-3-mobile`` = "is-offset-3-mobile"

    [<Literal>]
    let ``is-offset-3-tablet`` = "is-offset-3-tablet"

    [<Literal>]
    let ``is-offset-3-touch`` = "is-offset-3-touch"

    [<Literal>]
    let ``is-offset-3-desktop`` = "is-offset-3-desktop"

    [<Literal>]
    let ``is-offset-3-widescreen`` = "is-offset-3-widescreen"

    [<Literal>]
    let ``is-offset-3-fullhd`` = "is-offset-3-fullhd"

    [<Literal>]
    let ``is-offset-4`` = "is-offset-4"

    [<Literal>]
    let ``is-offset-4-mobile`` = "is-offset-4-mobile"

    [<Literal>]
    let ``is-offset-4-tablet`` = "is-offset-4-tablet"

    [<Literal>]
    let ``is-offset-4-touch`` = "is-offset-4-touch"

    [<Literal>]
    let ``is-offset-4-desktop`` = "is-offset-4-desktop"

    [<Literal>]
    let ``is-offset-4-widescreen`` = "is-offset-4-widescreen"

    [<Literal>]
    let ``is-offset-4-fullhd`` = "is-offset-4-fullhd"

    [<Literal>]
    let ``is-offset-5`` = "is-offset-5"

    [<Literal>]
    let ``is-offset-5-mobile`` = "is-offset-5-mobile"

    [<Literal>]
    let ``is-offset-5-tablet`` = "is-offset-5-tablet"

    [<Literal>]
    let ``is-offset-5-touch`` = "is-offset-5-touch"

    [<Literal>]
    let ``is-offset-5-desktop`` = "is-offset-5-desktop"

    [<Literal>]
    let ``is-offset-5-widescreen`` = "is-offset-5-widescreen"

    [<Literal>]
    let ``is-offset-5-fullhd`` = "is-offset-5-fullhd"

    [<Literal>]
    let ``is-offset-6`` = "is-offset-6"

    [<Literal>]
    let ``is-offset-6-mobile`` = "is-offset-6-mobile"

    [<Literal>]
    let ``is-offset-6-tablet`` = "is-offset-6-tablet"

    [<Literal>]
    let ``is-offset-6-touch`` = "is-offset-6-touch"

    [<Literal>]
    let ``is-offset-6-desktop`` = "is-offset-6-desktop"

    [<Literal>]
    let ``is-offset-6-widescreen`` = "is-offset-6-widescreen"

    [<Literal>]
    let ``is-offset-6-fullhd`` = "is-offset-6-fullhd"

    [<Literal>]
    let ``is-offset-7`` = "is-offset-7"

    [<Literal>]
    let ``is-offset-7-mobile`` = "is-offset-7-mobile"

    [<Literal>]
    let ``is-offset-7-tablet`` = "is-offset-7-tablet"

    [<Literal>]
    let ``is-offset-7-touch`` = "is-offset-7-touch"

    [<Literal>]
    let ``is-offset-7-desktop`` = "is-offset-7-desktop"

    [<Literal>]
    let ``is-offset-7-widescreen`` = "is-offset-7-widescreen"

    [<Literal>]
    let ``is-offset-7-fullhd`` = "is-offset-7-fullhd"

    [<Literal>]
    let ``is-offset-8`` = "is-offset-8"

    [<Literal>]
    let ``is-offset-8-mobile`` = "is-offset-8-mobile"

    [<Literal>]
    let ``is-offset-8-tablet`` = "is-offset-8-tablet"

    [<Literal>]
    let ``is-offset-8-touch`` = "is-offset-8-touch"

    [<Literal>]
    let ``is-offset-8-desktop`` = "is-offset-8-desktop"

    [<Literal>]
    let ``is-offset-8-widescreen`` = "is-offset-8-widescreen"

    [<Literal>]
    let ``is-offset-8-fullhd`` = "is-offset-8-fullhd"

    [<Literal>]
    let ``is-offset-9`` = "is-offset-9"

    [<Literal>]
    let ``is-offset-9-mobile`` = "is-offset-9-mobile"

    [<Literal>]
    let ``is-offset-9-tablet`` = "is-offset-9-tablet"

    [<Literal>]
    let ``is-offset-9-touch`` = "is-offset-9-touch"

    [<Literal>]
    let ``is-offset-9-desktop`` = "is-offset-9-desktop"

    [<Literal>]
    let ``is-offset-9-widescreen`` = "is-offset-9-widescreen"

    [<Literal>]
    let ``is-offset-9-fullhd`` = "is-offset-9-fullhd"

    [<Literal>]
    let ``is-offset-10`` = "is-offset-10"

    [<Literal>]
    let ``is-offset-10-mobile`` = "is-offset-10-mobile"

    [<Literal>]
    let ``is-offset-10-tablet`` = "is-offset-10-tablet"

    [<Literal>]
    let ``is-offset-10-touch`` = "is-offset-10-touch"

    [<Literal>]
    let ``is-offset-10-desktop`` = "is-offset-10-desktop"

    [<Literal>]
    let ``is-offset-10-widescreen`` = "is-offset-10-widescreen"

    [<Literal>]
    let ``is-offset-10-fullhd`` = "is-offset-10-fullhd"

    [<Literal>]
    let ``is-offset-11`` = "is-offset-11"

    [<Literal>]
    let ``is-offset-11-mobile`` = "is-offset-11-mobile"

    [<Literal>]
    let ``is-offset-11-tablet`` = "is-offset-11-tablet"

    [<Literal>]
    let ``is-offset-11-touch`` = "is-offset-11-touch"

    [<Literal>]
    let ``is-offset-11-desktop`` = "is-offset-11-desktop"

    [<Literal>]
    let ``is-offset-11-widescreen`` = "is-offset-11-widescreen"

    [<Literal>]
    let ``is-offset-11-fullhd`` = "is-offset-11-fullhd"

    [<Literal>]
    let ``is-offset-12`` = "is-offset-12"

    [<Literal>]
    let ``is-offset-12-mobile`` = "is-offset-12-mobile"

    [<Literal>]
    let ``is-offset-12-tablet`` = "is-offset-12-tablet"

    [<Literal>]
    let ``is-offset-12-touch`` = "is-offset-12-touch"

    [<Literal>]
    let ``is-offset-12-desktop`` = "is-offset-12-desktop"

    [<Literal>]
    let ``is-offset-12-widescreen`` = "is-offset-12-widescreen"

    [<Literal>]
    let ``is-offset-12-fullhd`` = "is-offset-12-fullhd"

    [<Literal>]
    let ``is-offset-three-quarters`` = "is-offset-three-quarters"

    [<Literal>]
    let ``is-offset-three-quarters-mobile`` = "is-offset-three-quarters-mobile"

    [<Literal>]
    let ``is-offset-three-quarters-tablet`` = "is-offset-three-quarters-tablet"

    [<Literal>]
    let ``is-offset-three-quarters-touch`` = "is-offset-three-quarters-touch"

    [<Literal>]
    let ``is-offset-three-quarters-desktop`` = "is-offset-three-quarters-desktop"

    [<Literal>]
    let ``is-offset-three-quarters-widescreen`` = "is-offset-three-quarters-widescreen"

    [<Literal>]
    let ``is-offset-three-quarters-fullhd`` = "is-offset-three-quarters-fullhd"

    [<Literal>]
    let ``is-offset-two-thirds`` = "is-offset-two-thirds"

    [<Literal>]
    let ``is-offset-two-thirds-mobile`` = "is-offset-two-thirds-mobile"

    [<Literal>]
    let ``is-offset-two-thirds-tablet`` = "is-offset-two-thirds-tablet"

    [<Literal>]
    let ``is-offset-two-thirds-touch`` = "is-offset-two-thirds-touch"

    [<Literal>]
    let ``is-offset-two-thirds-desktop`` = "is-offset-two-thirds-desktop"

    [<Literal>]
    let ``is-offset-two-thirds-widescreen`` = "is-offset-two-thirds-widescreen"

    [<Literal>]
    let ``is-offset-two-thirds-fullhd`` = "is-offset-two-thirds-fullhd"

    [<Literal>]
    let ``is-offset-half`` = "is-offset-half"

    [<Literal>]
    let ``is-offset-half-mobile`` = "is-offset-half-mobile"

    [<Literal>]
    let ``is-offset-half-tablet`` = "is-offset-half-tablet"

    [<Literal>]
    let ``is-offset-half-touch`` = "is-offset-half-touch"

    [<Literal>]
    let ``is-offset-half-desktop`` = "is-offset-half-desktop"

    [<Literal>]
    let ``is-offset-half-widescreen`` = "is-offset-half-widescreen"

    [<Literal>]
    let ``is-offset-half-fullhd`` = "is-offset-half-fullhd"

    [<Literal>]
    let ``is-offset-one-third`` = "is-offset-one-third"

    [<Literal>]
    let ``is-offset-one-third-mobile`` = "is-offset-one-third-mobile"

    [<Literal>]
    let ``is-offset-one-third-tablet`` = "is-offset-one-third-tablet"

    [<Literal>]
    let ``is-offset-one-third-touch`` = "is-offset-one-third-touch"

    [<Literal>]
    let ``is-offset-one-third-desktop`` = "is-offset-one-third-desktop"

    [<Literal>]
    let ``is-offset-one-third-widescreen`` = "is-offset-one-third-widescreen"

    [<Literal>]
    let ``is-offset-one-third-fullhd`` = "is-offset-one-third-fullhd"

    [<Literal>]
    let ``is-offset-one-quarter`` = "is-offset-one-quarter"

    [<Literal>]
    let ``is-offset-one-quarter-mobile`` = "is-offset-one-quarter-mobile"

    [<Literal>]
    let ``is-offset-one-quarter-tablet`` = "is-offset-one-quarter-tablet"

    [<Literal>]
    let ``is-offset-one-quarter-touch`` = "is-offset-one-quarter-touch"

    [<Literal>]
    let ``is-offset-one-quarter-desktop`` = "is-offset-one-quarter-desktop"

    [<Literal>]
    let ``is-offset-one-quarter-widescreen`` = "is-offset-one-quarter-widescreen"

    [<Literal>]
    let ``is-offset-one-quarter-fullhd`` = "is-offset-one-quarter-fullhd"

    [<Literal>]
    let ``is-offset-full`` = "is-offset-full"

    [<Literal>]
    let ``is-offset-full-mobile`` = "is-offset-full-mobile"

    [<Literal>]
    let ``is-offset-full-tablet`` = "is-offset-full-tablet"

    [<Literal>]
    let ``is-offset-full-touch`` = "is-offset-full-touch"

    [<Literal>]
    let ``is-offset-full-desktop`` = "is-offset-full-desktop"

    [<Literal>]
    let ``is-offset-full-widescreen`` = "is-offset-full-widescreen"

    [<Literal>]
    let ``is-offset-full-fullhd`` = "is-offset-full-fullhd"

    [<Literal>]
    let ``is-offset-four-fifths`` = "is-offset-four-fifths"

    [<Literal>]
    let ``is-offset-four-fifths-mobile`` = "is-offset-four-fifths-mobile"

    [<Literal>]
    let ``is-offset-four-fifths-tablet`` = "is-offset-four-fifths-tablet"

    [<Literal>]
    let ``is-offset-four-fifths-touch`` = "is-offset-four-fifths-touch"

    [<Literal>]
    let ``is-offset-four-fifths-desktop`` = "is-offset-four-fifths-desktop"

    [<Literal>]
    let ``is-offset-four-fifths-widescreen`` = "is-offset-four-fifths-widescreen"

    [<Literal>]
    let ``is-offset-four-fifths-fullhd`` = "is-offset-four-fifths-fullhd"

    [<Literal>]
    let ``is-offset-three-fifths`` = "is-offset-three-fifths"

    [<Literal>]
    let ``is-offset-three-fifths-mobile`` = "is-offset-three-fifths-mobile"

    [<Literal>]
    let ``is-offset-three-fifths-tablet`` = "is-offset-three-fifths-tablet"

    [<Literal>]
    let ``is-offset-three-fifths-touch`` = "is-offset-three-fifths-touch"

    [<Literal>]
    let ``is-offset-three-fifths-desktop`` = "is-offset-three-fifths-desktop"

    [<Literal>]
    let ``is-offset-three-fifths-widescreen`` = "is-offset-three-fifths-widescreen"

    [<Literal>]
    let ``is-offset-three-fifths-fullhd`` = "is-offset-three-fifths-fullhd"

    [<Literal>]
    let ``is-offset-two-fifths`` = "is-offset-two-fifths"

    [<Literal>]
    let ``is-offset-two-fifths-mobile`` = "is-offset-two-fifths-mobile"

    [<Literal>]
    let ``is-offset-two-fifths-tablet`` = "is-offset-two-fifths-tablet"

    [<Literal>]
    let ``is-offset-two-fifths-touch`` = "is-offset-two-fifths-touch"

    [<Literal>]
    let ``is-offset-two-fifths-desktop`` = "is-offset-two-fifths-desktop"

    [<Literal>]
    let ``is-offset-two-fifths-widescreen`` = "is-offset-two-fifths-widescreen"

    [<Literal>]
    let ``is-offset-two-fifths-fullhd`` = "is-offset-two-fifths-fullhd"

    [<Literal>]
    let ``is-offset-one-fifth`` = "is-offset-one-fifth"

    [<Literal>]
    let ``is-offset-one-fifth-mobile`` = "is-offset-one-fifth-mobile"

    [<Literal>]
    let ``is-offset-one-fifth-tablet`` = "is-offset-one-fifth-tablet"

    [<Literal>]
    let ``is-offset-one-fifth-touch`` = "is-offset-one-fifth-touch"

    [<Literal>]
    let ``is-offset-one-fifth-desktop`` = "is-offset-one-fifth-desktop"

    [<Literal>]
    let ``is-offset-one-fifth-widescreen`` = "is-offset-one-fifth-widescreen"

    [<Literal>]
    let ``is-offset-one-fifth-fullhd`` = "is-offset-one-fifth-fullhd"

    [<Literal>]
    let ``is-gapless`` = "is-gapless"

    [<Literal>]
    let ``is-multiline`` = "is-multiline"

    [<Literal>]
    let ``is-variable`` = "is-variable"

    [<Literal>]
    let ``is-vcentered`` = "is-vcentered"

    [<Literal>]
    let ``m-0`` = "m-0"

    [<Literal>]
    let ``m-1`` = "m-1"

    [<Literal>]
    let ``m-2`` = "m-2"

    [<Literal>]
    let ``m-3`` = "m-3"

    [<Literal>]
    let ``m-4`` = "m-4"

    [<Literal>]
    let ``m-5`` = "m-5"

    [<Literal>]
    let ``m-6`` = "m-6"

    [<Literal>]
    let ``m-auto`` = "m-auto"

    [<Literal>]
    let ``is-col-min-1`` = "is-col-min-1"

    [<Literal>]
    let ``is-col-min-2`` = "is-col-min-2"

    [<Literal>]
    let ``is-col-min-3`` = "is-col-min-3"

    [<Literal>]
    let ``is-col-min-4`` = "is-col-min-4"

    [<Literal>]
    let ``is-col-min-5`` = "is-col-min-5"

    [<Literal>]
    let ``is-col-min-6`` = "is-col-min-6"

    [<Literal>]
    let ``is-col-min-7`` = "is-col-min-7"

    [<Literal>]
    let ``is-col-min-8`` = "is-col-min-8"

    [<Literal>]
    let ``is-col-min-9`` = "is-col-min-9"

    [<Literal>]
    let ``is-col-min-10`` = "is-col-min-10"

    [<Literal>]
    let ``is-col-min-11`` = "is-col-min-11"

    [<Literal>]
    let ``is-col-min-12`` = "is-col-min-12"

    [<Literal>]
    let ``is-col-min-13`` = "is-col-min-13"

    [<Literal>]
    let ``is-col-min-14`` = "is-col-min-14"

    [<Literal>]
    let ``is-col-min-15`` = "is-col-min-15"

    [<Literal>]
    let ``is-col-min-16`` = "is-col-min-16"

    [<Literal>]
    let ``is-col-min-17`` = "is-col-min-17"

    [<Literal>]
    let ``is-col-min-18`` = "is-col-min-18"

    [<Literal>]
    let ``is-col-min-19`` = "is-col-min-19"

    [<Literal>]
    let ``is-col-min-20`` = "is-col-min-20"

    [<Literal>]
    let ``is-col-min-21`` = "is-col-min-21"

    [<Literal>]
    let ``is-col-min-22`` = "is-col-min-22"

    [<Literal>]
    let ``is-col-min-23`` = "is-col-min-23"

    [<Literal>]
    let ``is-col-min-24`` = "is-col-min-24"

    [<Literal>]
    let ``is-col-min-25`` = "is-col-min-25"

    [<Literal>]
    let ``is-col-min-26`` = "is-col-min-26"

    [<Literal>]
    let ``is-col-min-27`` = "is-col-min-27"

    [<Literal>]
    let ``is-col-min-28`` = "is-col-min-28"

    [<Literal>]
    let ``is-col-min-29`` = "is-col-min-29"

    [<Literal>]
    let ``is-col-min-30`` = "is-col-min-30"

    [<Literal>]
    let ``is-col-min-31`` = "is-col-min-31"

    [<Literal>]
    let ``is-col-min-32`` = "is-col-min-32"

    [<Literal>]
    let ``is-gap-0`` = "is-gap-0"

    [<Literal>]
    let ``is-gap-0.5`` = "is-gap-0.5"

    [<Literal>]
    let ``is-gap-1`` = "is-gap-1"

    [<Literal>]
    let ``is-gap-1.5`` = "is-gap-1.5"

    [<Literal>]
    let ``is-gap-2`` = "is-gap-2"

    [<Literal>]
    let ``is-gap-2.5`` = "is-gap-2.5"

    [<Literal>]
    let ``is-gap-3`` = "is-gap-3"

    [<Literal>]
    let ``is-gap-3.5`` = "is-gap-3.5"

    [<Literal>]
    let ``is-gap-4`` = "is-gap-4"

    [<Literal>]
    let ``is-gap-4.5`` = "is-gap-4.5"

    [<Literal>]
    let ``is-gap-5`` = "is-gap-5"

    [<Literal>]
    let ``is-gap-5.5`` = "is-gap-5.5"

    [<Literal>]
    let ``is-gap-6`` = "is-gap-6"

    [<Literal>]
    let ``is-gap-6.5`` = "is-gap-6.5"

    [<Literal>]
    let ``is-gap-7`` = "is-gap-7"

    [<Literal>]
    let ``is-gap-7.5`` = "is-gap-7.5"

    [<Literal>]
    let ``is-gap-8`` = "is-gap-8"

    [<Literal>]
    let ``is-column-gap-0`` = "is-column-gap-0"

    [<Literal>]
    let ``is-column-gap-0.5`` = "is-column-gap-0.5"

    [<Literal>]
    let ``is-column-gap-1`` = "is-column-gap-1"

    [<Literal>]
    let ``is-column-gap-1.5`` = "is-column-gap-1.5"

    [<Literal>]
    let ``is-column-gap-2`` = "is-column-gap-2"

    [<Literal>]
    let ``is-column-gap-2.5`` = "is-column-gap-2.5"

    [<Literal>]
    let ``is-column-gap-3`` = "is-column-gap-3"

    [<Literal>]
    let ``is-column-gap-3.5`` = "is-column-gap-3.5"

    [<Literal>]
    let ``is-column-gap-4`` = "is-column-gap-4"

    [<Literal>]
    let ``is-column-gap-4.5`` = "is-column-gap-4.5"

    [<Literal>]
    let ``is-column-gap-5`` = "is-column-gap-5"

    [<Literal>]
    let ``is-column-gap-5.5`` = "is-column-gap-5.5"

    [<Literal>]
    let ``is-column-gap-6`` = "is-column-gap-6"

    [<Literal>]
    let ``is-column-gap-6.5`` = "is-column-gap-6.5"

    [<Literal>]
    let ``is-column-gap-7`` = "is-column-gap-7"

    [<Literal>]
    let ``is-column-gap-7.5`` = "is-column-gap-7.5"

    [<Literal>]
    let ``is-column-gap-8`` = "is-column-gap-8"

    [<Literal>]
    let ``is-row-gap-0`` = "is-row-gap-0"

    [<Literal>]
    let ``is-row-gap-0.5`` = "is-row-gap-0.5"

    [<Literal>]
    let ``is-row-gap-1`` = "is-row-gap-1"

    [<Literal>]
    let ``is-row-gap-1.5`` = "is-row-gap-1.5"

    [<Literal>]
    let ``is-row-gap-2`` = "is-row-gap-2"

    [<Literal>]
    let ``is-row-gap-2.5`` = "is-row-gap-2.5"

    [<Literal>]
    let ``is-row-gap-3`` = "is-row-gap-3"

    [<Literal>]
    let ``is-row-gap-3.5`` = "is-row-gap-3.5"

    [<Literal>]
    let ``is-row-gap-4`` = "is-row-gap-4"

    [<Literal>]
    let ``is-row-gap-4.5`` = "is-row-gap-4.5"

    [<Literal>]
    let ``is-row-gap-5`` = "is-row-gap-5"

    [<Literal>]
    let ``is-row-gap-5.5`` = "is-row-gap-5.5"

    [<Literal>]
    let ``is-row-gap-6`` = "is-row-gap-6"

    [<Literal>]
    let ``is-row-gap-6.5`` = "is-row-gap-6.5"

    [<Literal>]
    let ``is-row-gap-7`` = "is-row-gap-7"

    [<Literal>]
    let ``is-row-gap-7.5`` = "is-row-gap-7.5"

    [<Literal>]
    let ``is-row-gap-8`` = "is-row-gap-8"

    [<Literal>]
    let ``has-auto-count`` = "has-auto-count"

    [<Literal>]
    let ``has-1-cols`` = "has-1-cols"

    [<Literal>]
    let ``has-2-cols`` = "has-2-cols"

    [<Literal>]
    let ``has-3-cols`` = "has-3-cols"

    [<Literal>]
    let ``has-4-cols`` = "has-4-cols"

    [<Literal>]
    let ``has-5-cols`` = "has-5-cols"

    [<Literal>]
    let ``has-6-cols`` = "has-6-cols"

    [<Literal>]
    let ``has-7-cols`` = "has-7-cols"

    [<Literal>]
    let ``has-8-cols`` = "has-8-cols"

    [<Literal>]
    let ``has-9-cols`` = "has-9-cols"

    [<Literal>]
    let ``has-10-cols`` = "has-10-cols"

    [<Literal>]
    let ``has-11-cols`` = "has-11-cols"

    [<Literal>]
    let ``has-12-cols`` = "has-12-cols"

    [<Literal>]
    let ``has-1-cols-mobile`` = "has-1-cols-mobile"

    [<Literal>]
    let ``has-2-cols-mobile`` = "has-2-cols-mobile"

    [<Literal>]
    let ``has-3-cols-mobile`` = "has-3-cols-mobile"

    [<Literal>]
    let ``has-4-cols-mobile`` = "has-4-cols-mobile"

    [<Literal>]
    let ``has-5-cols-mobile`` = "has-5-cols-mobile"

    [<Literal>]
    let ``has-6-cols-mobile`` = "has-6-cols-mobile"

    [<Literal>]
    let ``has-7-cols-mobile`` = "has-7-cols-mobile"

    [<Literal>]
    let ``has-8-cols-mobile`` = "has-8-cols-mobile"

    [<Literal>]
    let ``has-9-cols-mobile`` = "has-9-cols-mobile"

    [<Literal>]
    let ``has-10-cols-mobile`` = "has-10-cols-mobile"

    [<Literal>]
    let ``has-11-cols-mobile`` = "has-11-cols-mobile"

    [<Literal>]
    let ``has-12-cols-mobile`` = "has-12-cols-mobile"

    [<Literal>]
    let ``has-1-cols-tablet`` = "has-1-cols-tablet"

    [<Literal>]
    let ``has-2-cols-tablet`` = "has-2-cols-tablet"

    [<Literal>]
    let ``has-3-cols-tablet`` = "has-3-cols-tablet"

    [<Literal>]
    let ``has-4-cols-tablet`` = "has-4-cols-tablet"

    [<Literal>]
    let ``has-5-cols-tablet`` = "has-5-cols-tablet"

    [<Literal>]
    let ``has-6-cols-tablet`` = "has-6-cols-tablet"

    [<Literal>]
    let ``has-7-cols-tablet`` = "has-7-cols-tablet"

    [<Literal>]
    let ``has-8-cols-tablet`` = "has-8-cols-tablet"

    [<Literal>]
    let ``has-9-cols-tablet`` = "has-9-cols-tablet"

    [<Literal>]
    let ``has-10-cols-tablet`` = "has-10-cols-tablet"

    [<Literal>]
    let ``has-11-cols-tablet`` = "has-11-cols-tablet"

    [<Literal>]
    let ``has-12-cols-tablet`` = "has-12-cols-tablet"

    [<Literal>]
    let ``has-1-cols-desktop`` = "has-1-cols-desktop"

    [<Literal>]
    let ``has-2-cols-desktop`` = "has-2-cols-desktop"

    [<Literal>]
    let ``has-3-cols-desktop`` = "has-3-cols-desktop"

    [<Literal>]
    let ``has-4-cols-desktop`` = "has-4-cols-desktop"

    [<Literal>]
    let ``has-5-cols-desktop`` = "has-5-cols-desktop"

    [<Literal>]
    let ``has-6-cols-desktop`` = "has-6-cols-desktop"

    [<Literal>]
    let ``has-7-cols-desktop`` = "has-7-cols-desktop"

    [<Literal>]
    let ``has-8-cols-desktop`` = "has-8-cols-desktop"

    [<Literal>]
    let ``has-9-cols-desktop`` = "has-9-cols-desktop"

    [<Literal>]
    let ``has-10-cols-desktop`` = "has-10-cols-desktop"

    [<Literal>]
    let ``has-11-cols-desktop`` = "has-11-cols-desktop"

    [<Literal>]
    let ``has-12-cols-desktop`` = "has-12-cols-desktop"

    [<Literal>]
    let ``has-1-cols-widescreen`` = "has-1-cols-widescreen"

    [<Literal>]
    let ``has-2-cols-widescreen`` = "has-2-cols-widescreen"

    [<Literal>]
    let ``has-3-cols-widescreen`` = "has-3-cols-widescreen"

    [<Literal>]
    let ``has-4-cols-widescreen`` = "has-4-cols-widescreen"

    [<Literal>]
    let ``has-5-cols-widescreen`` = "has-5-cols-widescreen"

    [<Literal>]
    let ``has-6-cols-widescreen`` = "has-6-cols-widescreen"

    [<Literal>]
    let ``has-7-cols-widescreen`` = "has-7-cols-widescreen"

    [<Literal>]
    let ``has-8-cols-widescreen`` = "has-8-cols-widescreen"

    [<Literal>]
    let ``has-9-cols-widescreen`` = "has-9-cols-widescreen"

    [<Literal>]
    let ``has-10-cols-widescreen`` = "has-10-cols-widescreen"

    [<Literal>]
    let ``has-11-cols-widescreen`` = "has-11-cols-widescreen"

    [<Literal>]
    let ``has-12-cols-widescreen`` = "has-12-cols-widescreen"

    [<Literal>]
    let ``has-1-cols-fullhd`` = "has-1-cols-fullhd"

    [<Literal>]
    let ``has-2-cols-fullhd`` = "has-2-cols-fullhd"

    [<Literal>]
    let ``has-3-cols-fullhd`` = "has-3-cols-fullhd"

    [<Literal>]
    let ``has-4-cols-fullhd`` = "has-4-cols-fullhd"

    [<Literal>]
    let ``has-5-cols-fullhd`` = "has-5-cols-fullhd"

    [<Literal>]
    let ``has-6-cols-fullhd`` = "has-6-cols-fullhd"

    [<Literal>]
    let ``has-7-cols-fullhd`` = "has-7-cols-fullhd"

    [<Literal>]
    let ``has-8-cols-fullhd`` = "has-8-cols-fullhd"

    [<Literal>]
    let ``has-9-cols-fullhd`` = "has-9-cols-fullhd"

    [<Literal>]
    let ``has-10-cols-fullhd`` = "has-10-cols-fullhd"

    [<Literal>]
    let ``has-11-cols-fullhd`` = "has-11-cols-fullhd"

    [<Literal>]
    let ``has-12-cols-fullhd`` = "has-12-cols-fullhd"

    [<Literal>]
    let ``is-col-start-1`` = "is-col-start-1"

    [<Literal>]
    let ``is-col-start-2`` = "is-col-start-2"

    [<Literal>]
    let ``is-col-start-3`` = "is-col-start-3"

    [<Literal>]
    let ``is-col-start-4`` = "is-col-start-4"

    [<Literal>]
    let ``is-col-start-5`` = "is-col-start-5"

    [<Literal>]
    let ``is-col-start-6`` = "is-col-start-6"

    [<Literal>]
    let ``is-col-start-7`` = "is-col-start-7"

    [<Literal>]
    let ``is-col-start-8`` = "is-col-start-8"

    [<Literal>]
    let ``is-col-start-9`` = "is-col-start-9"

    [<Literal>]
    let ``is-col-start-10`` = "is-col-start-10"

    [<Literal>]
    let ``is-col-start-11`` = "is-col-start-11"

    [<Literal>]
    let ``is-col-start-12`` = "is-col-start-12"

    [<Literal>]
    let ``is-col-from-end-1`` = "is-col-from-end-1"

    [<Literal>]
    let ``is-col-from-end-2`` = "is-col-from-end-2"

    [<Literal>]
    let ``is-col-from-end-3`` = "is-col-from-end-3"

    [<Literal>]
    let ``is-col-from-end-4`` = "is-col-from-end-4"

    [<Literal>]
    let ``is-col-from-end-5`` = "is-col-from-end-5"

    [<Literal>]
    let ``is-col-from-end-6`` = "is-col-from-end-6"

    [<Literal>]
    let ``is-col-from-end-7`` = "is-col-from-end-7"

    [<Literal>]
    let ``is-col-from-end-8`` = "is-col-from-end-8"

    [<Literal>]
    let ``is-col-from-end-9`` = "is-col-from-end-9"

    [<Literal>]
    let ``is-col-from-end-10`` = "is-col-from-end-10"

    [<Literal>]
    let ``is-col-from-end-11`` = "is-col-from-end-11"

    [<Literal>]
    let ``is-col-from-end-12`` = "is-col-from-end-12"

    [<Literal>]
    let ``is-col-span-1`` = "is-col-span-1"

    [<Literal>]
    let ``is-col-span-2`` = "is-col-span-2"

    [<Literal>]
    let ``is-col-span-3`` = "is-col-span-3"

    [<Literal>]
    let ``is-col-span-4`` = "is-col-span-4"

    [<Literal>]
    let ``is-col-span-5`` = "is-col-span-5"

    [<Literal>]
    let ``is-col-span-6`` = "is-col-span-6"

    [<Literal>]
    let ``is-col-span-7`` = "is-col-span-7"

    [<Literal>]
    let ``is-col-span-8`` = "is-col-span-8"

    [<Literal>]
    let ``is-col-span-9`` = "is-col-span-9"

    [<Literal>]
    let ``is-col-span-10`` = "is-col-span-10"

    [<Literal>]
    let ``is-col-span-11`` = "is-col-span-11"

    [<Literal>]
    let ``is-col-span-12`` = "is-col-span-12"

    [<Literal>]
    let ``is-row-start-1`` = "is-row-start-1"

    [<Literal>]
    let ``is-row-start-2`` = "is-row-start-2"

    [<Literal>]
    let ``is-row-start-3`` = "is-row-start-3"

    [<Literal>]
    let ``is-row-start-4`` = "is-row-start-4"

    [<Literal>]
    let ``is-row-start-5`` = "is-row-start-5"

    [<Literal>]
    let ``is-row-start-6`` = "is-row-start-6"

    [<Literal>]
    let ``is-row-start-7`` = "is-row-start-7"

    [<Literal>]
    let ``is-row-start-8`` = "is-row-start-8"

    [<Literal>]
    let ``is-row-start-9`` = "is-row-start-9"

    [<Literal>]
    let ``is-row-start-10`` = "is-row-start-10"

    [<Literal>]
    let ``is-row-start-11`` = "is-row-start-11"

    [<Literal>]
    let ``is-row-start-12`` = "is-row-start-12"

    [<Literal>]
    let ``is-row-from-end-1`` = "is-row-from-end-1"

    [<Literal>]
    let ``is-row-from-end-2`` = "is-row-from-end-2"

    [<Literal>]
    let ``is-row-from-end-3`` = "is-row-from-end-3"

    [<Literal>]
    let ``is-row-from-end-4`` = "is-row-from-end-4"

    [<Literal>]
    let ``is-row-from-end-5`` = "is-row-from-end-5"

    [<Literal>]
    let ``is-row-from-end-6`` = "is-row-from-end-6"

    [<Literal>]
    let ``is-row-from-end-7`` = "is-row-from-end-7"

    [<Literal>]
    let ``is-row-from-end-8`` = "is-row-from-end-8"

    [<Literal>]
    let ``is-row-from-end-9`` = "is-row-from-end-9"

    [<Literal>]
    let ``is-row-from-end-10`` = "is-row-from-end-10"

    [<Literal>]
    let ``is-row-from-end-11`` = "is-row-from-end-11"

    [<Literal>]
    let ``is-row-from-end-12`` = "is-row-from-end-12"

    [<Literal>]
    let ``is-row-span-1`` = "is-row-span-1"

    [<Literal>]
    let ``is-row-span-2`` = "is-row-span-2"

    [<Literal>]
    let ``is-row-span-3`` = "is-row-span-3"

    [<Literal>]
    let ``is-row-span-4`` = "is-row-span-4"

    [<Literal>]
    let ``is-row-span-5`` = "is-row-span-5"

    [<Literal>]
    let ``is-row-span-6`` = "is-row-span-6"

    [<Literal>]
    let ``is-row-span-7`` = "is-row-span-7"

    [<Literal>]
    let ``is-row-span-8`` = "is-row-span-8"

    [<Literal>]
    let ``is-row-span-9`` = "is-row-span-9"

    [<Literal>]
    let ``is-row-span-10`` = "is-row-span-10"

    [<Literal>]
    let ``is-row-span-11`` = "is-row-span-11"

    [<Literal>]
    let ``is-row-span-12`` = "is-row-span-12"

    [<Literal>]
    let ``is-col-start-1-mobile`` = "is-col-start-1-mobile"

    [<Literal>]
    let ``is-col-start-2-mobile`` = "is-col-start-2-mobile"

    [<Literal>]
    let ``is-col-start-3-mobile`` = "is-col-start-3-mobile"

    [<Literal>]
    let ``is-col-start-4-mobile`` = "is-col-start-4-mobile"

    [<Literal>]
    let ``is-col-start-5-mobile`` = "is-col-start-5-mobile"

    [<Literal>]
    let ``is-col-start-6-mobile`` = "is-col-start-6-mobile"

    [<Literal>]
    let ``is-col-start-7-mobile`` = "is-col-start-7-mobile"

    [<Literal>]
    let ``is-col-start-8-mobile`` = "is-col-start-8-mobile"

    [<Literal>]
    let ``is-col-start-9-mobile`` = "is-col-start-9-mobile"

    [<Literal>]
    let ``is-col-start-10-mobile`` = "is-col-start-10-mobile"

    [<Literal>]
    let ``is-col-start-11-mobile`` = "is-col-start-11-mobile"

    [<Literal>]
    let ``is-col-start-12-mobile`` = "is-col-start-12-mobile"

    [<Literal>]
    let ``is-col-from-end-1-mobile`` = "is-col-from-end-1-mobile"

    [<Literal>]
    let ``is-col-from-end-2-mobile`` = "is-col-from-end-2-mobile"

    [<Literal>]
    let ``is-col-from-end-3-mobile`` = "is-col-from-end-3-mobile"

    [<Literal>]
    let ``is-col-from-end-4-mobile`` = "is-col-from-end-4-mobile"

    [<Literal>]
    let ``is-col-from-end-5-mobile`` = "is-col-from-end-5-mobile"

    [<Literal>]
    let ``is-col-from-end-6-mobile`` = "is-col-from-end-6-mobile"

    [<Literal>]
    let ``is-col-from-end-7-mobile`` = "is-col-from-end-7-mobile"

    [<Literal>]
    let ``is-col-from-end-8-mobile`` = "is-col-from-end-8-mobile"

    [<Literal>]
    let ``is-col-from-end-9-mobile`` = "is-col-from-end-9-mobile"

    [<Literal>]
    let ``is-col-from-end-10-mobile`` = "is-col-from-end-10-mobile"

    [<Literal>]
    let ``is-col-from-end-11-mobile`` = "is-col-from-end-11-mobile"

    [<Literal>]
    let ``is-col-from-end-12-mobile`` = "is-col-from-end-12-mobile"

    [<Literal>]
    let ``is-col-span-1-mobile`` = "is-col-span-1-mobile"

    [<Literal>]
    let ``is-col-span-2-mobile`` = "is-col-span-2-mobile"

    [<Literal>]
    let ``is-col-span-3-mobile`` = "is-col-span-3-mobile"

    [<Literal>]
    let ``is-col-span-4-mobile`` = "is-col-span-4-mobile"

    [<Literal>]
    let ``is-col-span-5-mobile`` = "is-col-span-5-mobile"

    [<Literal>]
    let ``is-col-span-6-mobile`` = "is-col-span-6-mobile"

    [<Literal>]
    let ``is-col-span-7-mobile`` = "is-col-span-7-mobile"

    [<Literal>]
    let ``is-col-span-8-mobile`` = "is-col-span-8-mobile"

    [<Literal>]
    let ``is-col-span-9-mobile`` = "is-col-span-9-mobile"

    [<Literal>]
    let ``is-col-span-10-mobile`` = "is-col-span-10-mobile"

    [<Literal>]
    let ``is-col-span-11-mobile`` = "is-col-span-11-mobile"

    [<Literal>]
    let ``is-col-span-12-mobile`` = "is-col-span-12-mobile"

    [<Literal>]
    let ``is-row-start-1-mobile`` = "is-row-start-1-mobile"

    [<Literal>]
    let ``is-row-start-2-mobile`` = "is-row-start-2-mobile"

    [<Literal>]
    let ``is-row-start-3-mobile`` = "is-row-start-3-mobile"

    [<Literal>]
    let ``is-row-start-4-mobile`` = "is-row-start-4-mobile"

    [<Literal>]
    let ``is-row-start-5-mobile`` = "is-row-start-5-mobile"

    [<Literal>]
    let ``is-row-start-6-mobile`` = "is-row-start-6-mobile"

    [<Literal>]
    let ``is-row-start-7-mobile`` = "is-row-start-7-mobile"

    [<Literal>]
    let ``is-row-start-8-mobile`` = "is-row-start-8-mobile"

    [<Literal>]
    let ``is-row-start-9-mobile`` = "is-row-start-9-mobile"

    [<Literal>]
    let ``is-row-start-10-mobile`` = "is-row-start-10-mobile"

    [<Literal>]
    let ``is-row-start-11-mobile`` = "is-row-start-11-mobile"

    [<Literal>]
    let ``is-row-start-12-mobile`` = "is-row-start-12-mobile"

    [<Literal>]
    let ``is-row-from-end-1-mobile`` = "is-row-from-end-1-mobile"

    [<Literal>]
    let ``is-row-from-end-2-mobile`` = "is-row-from-end-2-mobile"

    [<Literal>]
    let ``is-row-from-end-3-mobile`` = "is-row-from-end-3-mobile"

    [<Literal>]
    let ``is-row-from-end-4-mobile`` = "is-row-from-end-4-mobile"

    [<Literal>]
    let ``is-row-from-end-5-mobile`` = "is-row-from-end-5-mobile"

    [<Literal>]
    let ``is-row-from-end-6-mobile`` = "is-row-from-end-6-mobile"

    [<Literal>]
    let ``is-row-from-end-7-mobile`` = "is-row-from-end-7-mobile"

    [<Literal>]
    let ``is-row-from-end-8-mobile`` = "is-row-from-end-8-mobile"

    [<Literal>]
    let ``is-row-from-end-9-mobile`` = "is-row-from-end-9-mobile"

    [<Literal>]
    let ``is-row-from-end-10-mobile`` = "is-row-from-end-10-mobile"

    [<Literal>]
    let ``is-row-from-end-11-mobile`` = "is-row-from-end-11-mobile"

    [<Literal>]
    let ``is-row-from-end-12-mobile`` = "is-row-from-end-12-mobile"

    [<Literal>]
    let ``is-row-span-1-mobile`` = "is-row-span-1-mobile"

    [<Literal>]
    let ``is-row-span-2-mobile`` = "is-row-span-2-mobile"

    [<Literal>]
    let ``is-row-span-3-mobile`` = "is-row-span-3-mobile"

    [<Literal>]
    let ``is-row-span-4-mobile`` = "is-row-span-4-mobile"

    [<Literal>]
    let ``is-row-span-5-mobile`` = "is-row-span-5-mobile"

    [<Literal>]
    let ``is-row-span-6-mobile`` = "is-row-span-6-mobile"

    [<Literal>]
    let ``is-row-span-7-mobile`` = "is-row-span-7-mobile"

    [<Literal>]
    let ``is-row-span-8-mobile`` = "is-row-span-8-mobile"

    [<Literal>]
    let ``is-row-span-9-mobile`` = "is-row-span-9-mobile"

    [<Literal>]
    let ``is-row-span-10-mobile`` = "is-row-span-10-mobile"

    [<Literal>]
    let ``is-row-span-11-mobile`` = "is-row-span-11-mobile"

    [<Literal>]
    let ``is-row-span-12-mobile`` = "is-row-span-12-mobile"

    [<Literal>]
    let ``is-col-start-1-tablet`` = "is-col-start-1-tablet"

    [<Literal>]
    let ``is-col-start-2-tablet`` = "is-col-start-2-tablet"

    [<Literal>]
    let ``is-col-start-3-tablet`` = "is-col-start-3-tablet"

    [<Literal>]
    let ``is-col-start-4-tablet`` = "is-col-start-4-tablet"

    [<Literal>]
    let ``is-col-start-5-tablet`` = "is-col-start-5-tablet"

    [<Literal>]
    let ``is-col-start-6-tablet`` = "is-col-start-6-tablet"

    [<Literal>]
    let ``is-col-start-7-tablet`` = "is-col-start-7-tablet"

    [<Literal>]
    let ``is-col-start-8-tablet`` = "is-col-start-8-tablet"

    [<Literal>]
    let ``is-col-start-9-tablet`` = "is-col-start-9-tablet"

    [<Literal>]
    let ``is-col-start-10-tablet`` = "is-col-start-10-tablet"

    [<Literal>]
    let ``is-col-start-11-tablet`` = "is-col-start-11-tablet"

    [<Literal>]
    let ``is-col-start-12-tablet`` = "is-col-start-12-tablet"

    [<Literal>]
    let ``is-col-from-end-1-tablet`` = "is-col-from-end-1-tablet"

    [<Literal>]
    let ``is-col-from-end-2-tablet`` = "is-col-from-end-2-tablet"

    [<Literal>]
    let ``is-col-from-end-3-tablet`` = "is-col-from-end-3-tablet"

    [<Literal>]
    let ``is-col-from-end-4-tablet`` = "is-col-from-end-4-tablet"

    [<Literal>]
    let ``is-col-from-end-5-tablet`` = "is-col-from-end-5-tablet"

    [<Literal>]
    let ``is-col-from-end-6-tablet`` = "is-col-from-end-6-tablet"

    [<Literal>]
    let ``is-col-from-end-7-tablet`` = "is-col-from-end-7-tablet"

    [<Literal>]
    let ``is-col-from-end-8-tablet`` = "is-col-from-end-8-tablet"

    [<Literal>]
    let ``is-col-from-end-9-tablet`` = "is-col-from-end-9-tablet"

    [<Literal>]
    let ``is-col-from-end-10-tablet`` = "is-col-from-end-10-tablet"

    [<Literal>]
    let ``is-col-from-end-11-tablet`` = "is-col-from-end-11-tablet"

    [<Literal>]
    let ``is-col-from-end-12-tablet`` = "is-col-from-end-12-tablet"

    [<Literal>]
    let ``is-col-span-1-tablet`` = "is-col-span-1-tablet"

    [<Literal>]
    let ``is-col-span-2-tablet`` = "is-col-span-2-tablet"

    [<Literal>]
    let ``is-col-span-3-tablet`` = "is-col-span-3-tablet"

    [<Literal>]
    let ``is-col-span-4-tablet`` = "is-col-span-4-tablet"

    [<Literal>]
    let ``is-col-span-5-tablet`` = "is-col-span-5-tablet"

    [<Literal>]
    let ``is-col-span-6-tablet`` = "is-col-span-6-tablet"

    [<Literal>]
    let ``is-col-span-7-tablet`` = "is-col-span-7-tablet"

    [<Literal>]
    let ``is-col-span-8-tablet`` = "is-col-span-8-tablet"

    [<Literal>]
    let ``is-col-span-9-tablet`` = "is-col-span-9-tablet"

    [<Literal>]
    let ``is-col-span-10-tablet`` = "is-col-span-10-tablet"

    [<Literal>]
    let ``is-col-span-11-tablet`` = "is-col-span-11-tablet"

    [<Literal>]
    let ``is-col-span-12-tablet`` = "is-col-span-12-tablet"

    [<Literal>]
    let ``is-row-start-1-tablet`` = "is-row-start-1-tablet"

    [<Literal>]
    let ``is-row-start-2-tablet`` = "is-row-start-2-tablet"

    [<Literal>]
    let ``is-row-start-3-tablet`` = "is-row-start-3-tablet"

    [<Literal>]
    let ``is-row-start-4-tablet`` = "is-row-start-4-tablet"

    [<Literal>]
    let ``is-row-start-5-tablet`` = "is-row-start-5-tablet"

    [<Literal>]
    let ``is-row-start-6-tablet`` = "is-row-start-6-tablet"

    [<Literal>]
    let ``is-row-start-7-tablet`` = "is-row-start-7-tablet"

    [<Literal>]
    let ``is-row-start-8-tablet`` = "is-row-start-8-tablet"

    [<Literal>]
    let ``is-row-start-9-tablet`` = "is-row-start-9-tablet"

    [<Literal>]
    let ``is-row-start-10-tablet`` = "is-row-start-10-tablet"

    [<Literal>]
    let ``is-row-start-11-tablet`` = "is-row-start-11-tablet"

    [<Literal>]
    let ``is-row-start-12-tablet`` = "is-row-start-12-tablet"

    [<Literal>]
    let ``is-row-from-end-1-tablet`` = "is-row-from-end-1-tablet"

    [<Literal>]
    let ``is-row-from-end-2-tablet`` = "is-row-from-end-2-tablet"

    [<Literal>]
    let ``is-row-from-end-3-tablet`` = "is-row-from-end-3-tablet"

    [<Literal>]
    let ``is-row-from-end-4-tablet`` = "is-row-from-end-4-tablet"

    [<Literal>]
    let ``is-row-from-end-5-tablet`` = "is-row-from-end-5-tablet"

    [<Literal>]
    let ``is-row-from-end-6-tablet`` = "is-row-from-end-6-tablet"

    [<Literal>]
    let ``is-row-from-end-7-tablet`` = "is-row-from-end-7-tablet"

    [<Literal>]
    let ``is-row-from-end-8-tablet`` = "is-row-from-end-8-tablet"

    [<Literal>]
    let ``is-row-from-end-9-tablet`` = "is-row-from-end-9-tablet"

    [<Literal>]
    let ``is-row-from-end-10-tablet`` = "is-row-from-end-10-tablet"

    [<Literal>]
    let ``is-row-from-end-11-tablet`` = "is-row-from-end-11-tablet"

    [<Literal>]
    let ``is-row-from-end-12-tablet`` = "is-row-from-end-12-tablet"

    [<Literal>]
    let ``is-row-span-1-tablet`` = "is-row-span-1-tablet"

    [<Literal>]
    let ``is-row-span-2-tablet`` = "is-row-span-2-tablet"

    [<Literal>]
    let ``is-row-span-3-tablet`` = "is-row-span-3-tablet"

    [<Literal>]
    let ``is-row-span-4-tablet`` = "is-row-span-4-tablet"

    [<Literal>]
    let ``is-row-span-5-tablet`` = "is-row-span-5-tablet"

    [<Literal>]
    let ``is-row-span-6-tablet`` = "is-row-span-6-tablet"

    [<Literal>]
    let ``is-row-span-7-tablet`` = "is-row-span-7-tablet"

    [<Literal>]
    let ``is-row-span-8-tablet`` = "is-row-span-8-tablet"

    [<Literal>]
    let ``is-row-span-9-tablet`` = "is-row-span-9-tablet"

    [<Literal>]
    let ``is-row-span-10-tablet`` = "is-row-span-10-tablet"

    [<Literal>]
    let ``is-row-span-11-tablet`` = "is-row-span-11-tablet"

    [<Literal>]
    let ``is-row-span-12-tablet`` = "is-row-span-12-tablet"

    [<Literal>]
    let ``is-col-start-1-tablet-only`` = "is-col-start-1-tablet-only"

    [<Literal>]
    let ``is-col-start-2-tablet-only`` = "is-col-start-2-tablet-only"

    [<Literal>]
    let ``is-col-start-3-tablet-only`` = "is-col-start-3-tablet-only"

    [<Literal>]
    let ``is-col-start-4-tablet-only`` = "is-col-start-4-tablet-only"

    [<Literal>]
    let ``is-col-start-5-tablet-only`` = "is-col-start-5-tablet-only"

    [<Literal>]
    let ``is-col-start-6-tablet-only`` = "is-col-start-6-tablet-only"

    [<Literal>]
    let ``is-col-start-7-tablet-only`` = "is-col-start-7-tablet-only"

    [<Literal>]
    let ``is-col-start-8-tablet-only`` = "is-col-start-8-tablet-only"

    [<Literal>]
    let ``is-col-start-9-tablet-only`` = "is-col-start-9-tablet-only"

    [<Literal>]
    let ``is-col-start-10-tablet-only`` = "is-col-start-10-tablet-only"

    [<Literal>]
    let ``is-col-start-11-tablet-only`` = "is-col-start-11-tablet-only"

    [<Literal>]
    let ``is-col-start-12-tablet-only`` = "is-col-start-12-tablet-only"

    [<Literal>]
    let ``is-col-from-end-1-tablet-only`` = "is-col-from-end-1-tablet-only"

    [<Literal>]
    let ``is-col-from-end-2-tablet-only`` = "is-col-from-end-2-tablet-only"

    [<Literal>]
    let ``is-col-from-end-3-tablet-only`` = "is-col-from-end-3-tablet-only"

    [<Literal>]
    let ``is-col-from-end-4-tablet-only`` = "is-col-from-end-4-tablet-only"

    [<Literal>]
    let ``is-col-from-end-5-tablet-only`` = "is-col-from-end-5-tablet-only"

    [<Literal>]
    let ``is-col-from-end-6-tablet-only`` = "is-col-from-end-6-tablet-only"

    [<Literal>]
    let ``is-col-from-end-7-tablet-only`` = "is-col-from-end-7-tablet-only"

    [<Literal>]
    let ``is-col-from-end-8-tablet-only`` = "is-col-from-end-8-tablet-only"

    [<Literal>]
    let ``is-col-from-end-9-tablet-only`` = "is-col-from-end-9-tablet-only"

    [<Literal>]
    let ``is-col-from-end-10-tablet-only`` = "is-col-from-end-10-tablet-only"

    [<Literal>]
    let ``is-col-from-end-11-tablet-only`` = "is-col-from-end-11-tablet-only"

    [<Literal>]
    let ``is-col-from-end-12-tablet-only`` = "is-col-from-end-12-tablet-only"

    [<Literal>]
    let ``is-col-span-1-tablet-only`` = "is-col-span-1-tablet-only"

    [<Literal>]
    let ``is-col-span-2-tablet-only`` = "is-col-span-2-tablet-only"

    [<Literal>]
    let ``is-col-span-3-tablet-only`` = "is-col-span-3-tablet-only"

    [<Literal>]
    let ``is-col-span-4-tablet-only`` = "is-col-span-4-tablet-only"

    [<Literal>]
    let ``is-col-span-5-tablet-only`` = "is-col-span-5-tablet-only"

    [<Literal>]
    let ``is-col-span-6-tablet-only`` = "is-col-span-6-tablet-only"

    [<Literal>]
    let ``is-col-span-7-tablet-only`` = "is-col-span-7-tablet-only"

    [<Literal>]
    let ``is-col-span-8-tablet-only`` = "is-col-span-8-tablet-only"

    [<Literal>]
    let ``is-col-span-9-tablet-only`` = "is-col-span-9-tablet-only"

    [<Literal>]
    let ``is-col-span-10-tablet-only`` = "is-col-span-10-tablet-only"

    [<Literal>]
    let ``is-col-span-11-tablet-only`` = "is-col-span-11-tablet-only"

    [<Literal>]
    let ``is-col-span-12-tablet-only`` = "is-col-span-12-tablet-only"

    [<Literal>]
    let ``is-row-start-1-tablet-only`` = "is-row-start-1-tablet-only"

    [<Literal>]
    let ``is-row-start-2-tablet-only`` = "is-row-start-2-tablet-only"

    [<Literal>]
    let ``is-row-start-3-tablet-only`` = "is-row-start-3-tablet-only"

    [<Literal>]
    let ``is-row-start-4-tablet-only`` = "is-row-start-4-tablet-only"

    [<Literal>]
    let ``is-row-start-5-tablet-only`` = "is-row-start-5-tablet-only"

    [<Literal>]
    let ``is-row-start-6-tablet-only`` = "is-row-start-6-tablet-only"

    [<Literal>]
    let ``is-row-start-7-tablet-only`` = "is-row-start-7-tablet-only"

    [<Literal>]
    let ``is-row-start-8-tablet-only`` = "is-row-start-8-tablet-only"

    [<Literal>]
    let ``is-row-start-9-tablet-only`` = "is-row-start-9-tablet-only"

    [<Literal>]
    let ``is-row-start-10-tablet-only`` = "is-row-start-10-tablet-only"

    [<Literal>]
    let ``is-row-start-11-tablet-only`` = "is-row-start-11-tablet-only"

    [<Literal>]
    let ``is-row-start-12-tablet-only`` = "is-row-start-12-tablet-only"

    [<Literal>]
    let ``is-row-from-end-1-tablet-only`` = "is-row-from-end-1-tablet-only"

    [<Literal>]
    let ``is-row-from-end-2-tablet-only`` = "is-row-from-end-2-tablet-only"

    [<Literal>]
    let ``is-row-from-end-3-tablet-only`` = "is-row-from-end-3-tablet-only"

    [<Literal>]
    let ``is-row-from-end-4-tablet-only`` = "is-row-from-end-4-tablet-only"

    [<Literal>]
    let ``is-row-from-end-5-tablet-only`` = "is-row-from-end-5-tablet-only"

    [<Literal>]
    let ``is-row-from-end-6-tablet-only`` = "is-row-from-end-6-tablet-only"

    [<Literal>]
    let ``is-row-from-end-7-tablet-only`` = "is-row-from-end-7-tablet-only"

    [<Literal>]
    let ``is-row-from-end-8-tablet-only`` = "is-row-from-end-8-tablet-only"

    [<Literal>]
    let ``is-row-from-end-9-tablet-only`` = "is-row-from-end-9-tablet-only"

    [<Literal>]
    let ``is-row-from-end-10-tablet-only`` = "is-row-from-end-10-tablet-only"

    [<Literal>]
    let ``is-row-from-end-11-tablet-only`` = "is-row-from-end-11-tablet-only"

    [<Literal>]
    let ``is-row-from-end-12-tablet-only`` = "is-row-from-end-12-tablet-only"

    [<Literal>]
    let ``is-row-span-1-tablet-only`` = "is-row-span-1-tablet-only"

    [<Literal>]
    let ``is-row-span-2-tablet-only`` = "is-row-span-2-tablet-only"

    [<Literal>]
    let ``is-row-span-3-tablet-only`` = "is-row-span-3-tablet-only"

    [<Literal>]
    let ``is-row-span-4-tablet-only`` = "is-row-span-4-tablet-only"

    [<Literal>]
    let ``is-row-span-5-tablet-only`` = "is-row-span-5-tablet-only"

    [<Literal>]
    let ``is-row-span-6-tablet-only`` = "is-row-span-6-tablet-only"

    [<Literal>]
    let ``is-row-span-7-tablet-only`` = "is-row-span-7-tablet-only"

    [<Literal>]
    let ``is-row-span-8-tablet-only`` = "is-row-span-8-tablet-only"

    [<Literal>]
    let ``is-row-span-9-tablet-only`` = "is-row-span-9-tablet-only"

    [<Literal>]
    let ``is-row-span-10-tablet-only`` = "is-row-span-10-tablet-only"

    [<Literal>]
    let ``is-row-span-11-tablet-only`` = "is-row-span-11-tablet-only"

    [<Literal>]
    let ``is-row-span-12-tablet-only`` = "is-row-span-12-tablet-only"

    [<Literal>]
    let ``is-col-start-1-desktop`` = "is-col-start-1-desktop"

    [<Literal>]
    let ``is-col-start-2-desktop`` = "is-col-start-2-desktop"

    [<Literal>]
    let ``is-col-start-3-desktop`` = "is-col-start-3-desktop"

    [<Literal>]
    let ``is-col-start-4-desktop`` = "is-col-start-4-desktop"

    [<Literal>]
    let ``is-col-start-5-desktop`` = "is-col-start-5-desktop"

    [<Literal>]
    let ``is-col-start-6-desktop`` = "is-col-start-6-desktop"

    [<Literal>]
    let ``is-col-start-7-desktop`` = "is-col-start-7-desktop"

    [<Literal>]
    let ``is-col-start-8-desktop`` = "is-col-start-8-desktop"

    [<Literal>]
    let ``is-col-start-9-desktop`` = "is-col-start-9-desktop"

    [<Literal>]
    let ``is-col-start-10-desktop`` = "is-col-start-10-desktop"

    [<Literal>]
    let ``is-col-start-11-desktop`` = "is-col-start-11-desktop"

    [<Literal>]
    let ``is-col-start-12-desktop`` = "is-col-start-12-desktop"

    [<Literal>]
    let ``is-col-from-end-1-desktop`` = "is-col-from-end-1-desktop"

    [<Literal>]
    let ``is-col-from-end-2-desktop`` = "is-col-from-end-2-desktop"

    [<Literal>]
    let ``is-col-from-end-3-desktop`` = "is-col-from-end-3-desktop"

    [<Literal>]
    let ``is-col-from-end-4-desktop`` = "is-col-from-end-4-desktop"

    [<Literal>]
    let ``is-col-from-end-5-desktop`` = "is-col-from-end-5-desktop"

    [<Literal>]
    let ``is-col-from-end-6-desktop`` = "is-col-from-end-6-desktop"

    [<Literal>]
    let ``is-col-from-end-7-desktop`` = "is-col-from-end-7-desktop"

    [<Literal>]
    let ``is-col-from-end-8-desktop`` = "is-col-from-end-8-desktop"

    [<Literal>]
    let ``is-col-from-end-9-desktop`` = "is-col-from-end-9-desktop"

    [<Literal>]
    let ``is-col-from-end-10-desktop`` = "is-col-from-end-10-desktop"

    [<Literal>]
    let ``is-col-from-end-11-desktop`` = "is-col-from-end-11-desktop"

    [<Literal>]
    let ``is-col-from-end-12-desktop`` = "is-col-from-end-12-desktop"

    [<Literal>]
    let ``is-col-span-1-desktop`` = "is-col-span-1-desktop"

    [<Literal>]
    let ``is-col-span-2-desktop`` = "is-col-span-2-desktop"

    [<Literal>]
    let ``is-col-span-3-desktop`` = "is-col-span-3-desktop"

    [<Literal>]
    let ``is-col-span-4-desktop`` = "is-col-span-4-desktop"

    [<Literal>]
    let ``is-col-span-5-desktop`` = "is-col-span-5-desktop"

    [<Literal>]
    let ``is-col-span-6-desktop`` = "is-col-span-6-desktop"

    [<Literal>]
    let ``is-col-span-7-desktop`` = "is-col-span-7-desktop"

    [<Literal>]
    let ``is-col-span-8-desktop`` = "is-col-span-8-desktop"

    [<Literal>]
    let ``is-col-span-9-desktop`` = "is-col-span-9-desktop"

    [<Literal>]
    let ``is-col-span-10-desktop`` = "is-col-span-10-desktop"

    [<Literal>]
    let ``is-col-span-11-desktop`` = "is-col-span-11-desktop"

    [<Literal>]
    let ``is-col-span-12-desktop`` = "is-col-span-12-desktop"

    [<Literal>]
    let ``is-row-start-1-desktop`` = "is-row-start-1-desktop"

    [<Literal>]
    let ``is-row-start-2-desktop`` = "is-row-start-2-desktop"

    [<Literal>]
    let ``is-row-start-3-desktop`` = "is-row-start-3-desktop"

    [<Literal>]
    let ``is-row-start-4-desktop`` = "is-row-start-4-desktop"

    [<Literal>]
    let ``is-row-start-5-desktop`` = "is-row-start-5-desktop"

    [<Literal>]
    let ``is-row-start-6-desktop`` = "is-row-start-6-desktop"

    [<Literal>]
    let ``is-row-start-7-desktop`` = "is-row-start-7-desktop"

    [<Literal>]
    let ``is-row-start-8-desktop`` = "is-row-start-8-desktop"

    [<Literal>]
    let ``is-row-start-9-desktop`` = "is-row-start-9-desktop"

    [<Literal>]
    let ``is-row-start-10-desktop`` = "is-row-start-10-desktop"

    [<Literal>]
    let ``is-row-start-11-desktop`` = "is-row-start-11-desktop"

    [<Literal>]
    let ``is-row-start-12-desktop`` = "is-row-start-12-desktop"

    [<Literal>]
    let ``is-row-from-end-1-desktop`` = "is-row-from-end-1-desktop"

    [<Literal>]
    let ``is-row-from-end-2-desktop`` = "is-row-from-end-2-desktop"

    [<Literal>]
    let ``is-row-from-end-3-desktop`` = "is-row-from-end-3-desktop"

    [<Literal>]
    let ``is-row-from-end-4-desktop`` = "is-row-from-end-4-desktop"

    [<Literal>]
    let ``is-row-from-end-5-desktop`` = "is-row-from-end-5-desktop"

    [<Literal>]
    let ``is-row-from-end-6-desktop`` = "is-row-from-end-6-desktop"

    [<Literal>]
    let ``is-row-from-end-7-desktop`` = "is-row-from-end-7-desktop"

    [<Literal>]
    let ``is-row-from-end-8-desktop`` = "is-row-from-end-8-desktop"

    [<Literal>]
    let ``is-row-from-end-9-desktop`` = "is-row-from-end-9-desktop"

    [<Literal>]
    let ``is-row-from-end-10-desktop`` = "is-row-from-end-10-desktop"

    [<Literal>]
    let ``is-row-from-end-11-desktop`` = "is-row-from-end-11-desktop"

    [<Literal>]
    let ``is-row-from-end-12-desktop`` = "is-row-from-end-12-desktop"

    [<Literal>]
    let ``is-row-span-1-desktop`` = "is-row-span-1-desktop"

    [<Literal>]
    let ``is-row-span-2-desktop`` = "is-row-span-2-desktop"

    [<Literal>]
    let ``is-row-span-3-desktop`` = "is-row-span-3-desktop"

    [<Literal>]
    let ``is-row-span-4-desktop`` = "is-row-span-4-desktop"

    [<Literal>]
    let ``is-row-span-5-desktop`` = "is-row-span-5-desktop"

    [<Literal>]
    let ``is-row-span-6-desktop`` = "is-row-span-6-desktop"

    [<Literal>]
    let ``is-row-span-7-desktop`` = "is-row-span-7-desktop"

    [<Literal>]
    let ``is-row-span-8-desktop`` = "is-row-span-8-desktop"

    [<Literal>]
    let ``is-row-span-9-desktop`` = "is-row-span-9-desktop"

    [<Literal>]
    let ``is-row-span-10-desktop`` = "is-row-span-10-desktop"

    [<Literal>]
    let ``is-row-span-11-desktop`` = "is-row-span-11-desktop"

    [<Literal>]
    let ``is-row-span-12-desktop`` = "is-row-span-12-desktop"

    [<Literal>]
    let ``is-col-start-1-desktop-only`` = "is-col-start-1-desktop-only"

    [<Literal>]
    let ``is-col-start-2-desktop-only`` = "is-col-start-2-desktop-only"

    [<Literal>]
    let ``is-col-start-3-desktop-only`` = "is-col-start-3-desktop-only"

    [<Literal>]
    let ``is-col-start-4-desktop-only`` = "is-col-start-4-desktop-only"

    [<Literal>]
    let ``is-col-start-5-desktop-only`` = "is-col-start-5-desktop-only"

    [<Literal>]
    let ``is-col-start-6-desktop-only`` = "is-col-start-6-desktop-only"

    [<Literal>]
    let ``is-col-start-7-desktop-only`` = "is-col-start-7-desktop-only"

    [<Literal>]
    let ``is-col-start-8-desktop-only`` = "is-col-start-8-desktop-only"

    [<Literal>]
    let ``is-col-start-9-desktop-only`` = "is-col-start-9-desktop-only"

    [<Literal>]
    let ``is-col-start-10-desktop-only`` = "is-col-start-10-desktop-only"

    [<Literal>]
    let ``is-col-start-11-desktop-only`` = "is-col-start-11-desktop-only"

    [<Literal>]
    let ``is-col-start-12-desktop-only`` = "is-col-start-12-desktop-only"

    [<Literal>]
    let ``is-col-from-end-1-desktop-only`` = "is-col-from-end-1-desktop-only"

    [<Literal>]
    let ``is-col-from-end-2-desktop-only`` = "is-col-from-end-2-desktop-only"

    [<Literal>]
    let ``is-col-from-end-3-desktop-only`` = "is-col-from-end-3-desktop-only"

    [<Literal>]
    let ``is-col-from-end-4-desktop-only`` = "is-col-from-end-4-desktop-only"

    [<Literal>]
    let ``is-col-from-end-5-desktop-only`` = "is-col-from-end-5-desktop-only"

    [<Literal>]
    let ``is-col-from-end-6-desktop-only`` = "is-col-from-end-6-desktop-only"

    [<Literal>]
    let ``is-col-from-end-7-desktop-only`` = "is-col-from-end-7-desktop-only"

    [<Literal>]
    let ``is-col-from-end-8-desktop-only`` = "is-col-from-end-8-desktop-only"

    [<Literal>]
    let ``is-col-from-end-9-desktop-only`` = "is-col-from-end-9-desktop-only"

    [<Literal>]
    let ``is-col-from-end-10-desktop-only`` = "is-col-from-end-10-desktop-only"

    [<Literal>]
    let ``is-col-from-end-11-desktop-only`` = "is-col-from-end-11-desktop-only"

    [<Literal>]
    let ``is-col-from-end-12-desktop-only`` = "is-col-from-end-12-desktop-only"

    [<Literal>]
    let ``is-col-span-1-desktop-only`` = "is-col-span-1-desktop-only"

    [<Literal>]
    let ``is-col-span-2-desktop-only`` = "is-col-span-2-desktop-only"

    [<Literal>]
    let ``is-col-span-3-desktop-only`` = "is-col-span-3-desktop-only"

    [<Literal>]
    let ``is-col-span-4-desktop-only`` = "is-col-span-4-desktop-only"

    [<Literal>]
    let ``is-col-span-5-desktop-only`` = "is-col-span-5-desktop-only"

    [<Literal>]
    let ``is-col-span-6-desktop-only`` = "is-col-span-6-desktop-only"

    [<Literal>]
    let ``is-col-span-7-desktop-only`` = "is-col-span-7-desktop-only"

    [<Literal>]
    let ``is-col-span-8-desktop-only`` = "is-col-span-8-desktop-only"

    [<Literal>]
    let ``is-col-span-9-desktop-only`` = "is-col-span-9-desktop-only"

    [<Literal>]
    let ``is-col-span-10-desktop-only`` = "is-col-span-10-desktop-only"

    [<Literal>]
    let ``is-col-span-11-desktop-only`` = "is-col-span-11-desktop-only"

    [<Literal>]
    let ``is-col-span-12-desktop-only`` = "is-col-span-12-desktop-only"

    [<Literal>]
    let ``is-row-start-1-desktop-only`` = "is-row-start-1-desktop-only"

    [<Literal>]
    let ``is-row-start-2-desktop-only`` = "is-row-start-2-desktop-only"

    [<Literal>]
    let ``is-row-start-3-desktop-only`` = "is-row-start-3-desktop-only"

    [<Literal>]
    let ``is-row-start-4-desktop-only`` = "is-row-start-4-desktop-only"

    [<Literal>]
    let ``is-row-start-5-desktop-only`` = "is-row-start-5-desktop-only"

    [<Literal>]
    let ``is-row-start-6-desktop-only`` = "is-row-start-6-desktop-only"

    [<Literal>]
    let ``is-row-start-7-desktop-only`` = "is-row-start-7-desktop-only"

    [<Literal>]
    let ``is-row-start-8-desktop-only`` = "is-row-start-8-desktop-only"

    [<Literal>]
    let ``is-row-start-9-desktop-only`` = "is-row-start-9-desktop-only"

    [<Literal>]
    let ``is-row-start-10-desktop-only`` = "is-row-start-10-desktop-only"

    [<Literal>]
    let ``is-row-start-11-desktop-only`` = "is-row-start-11-desktop-only"

    [<Literal>]
    let ``is-row-start-12-desktop-only`` = "is-row-start-12-desktop-only"

    [<Literal>]
    let ``is-row-from-end-1-desktop-only`` = "is-row-from-end-1-desktop-only"

    [<Literal>]
    let ``is-row-from-end-2-desktop-only`` = "is-row-from-end-2-desktop-only"

    [<Literal>]
    let ``is-row-from-end-3-desktop-only`` = "is-row-from-end-3-desktop-only"

    [<Literal>]
    let ``is-row-from-end-4-desktop-only`` = "is-row-from-end-4-desktop-only"

    [<Literal>]
    let ``is-row-from-end-5-desktop-only`` = "is-row-from-end-5-desktop-only"

    [<Literal>]
    let ``is-row-from-end-6-desktop-only`` = "is-row-from-end-6-desktop-only"

    [<Literal>]
    let ``is-row-from-end-7-desktop-only`` = "is-row-from-end-7-desktop-only"

    [<Literal>]
    let ``is-row-from-end-8-desktop-only`` = "is-row-from-end-8-desktop-only"

    [<Literal>]
    let ``is-row-from-end-9-desktop-only`` = "is-row-from-end-9-desktop-only"

    [<Literal>]
    let ``is-row-from-end-10-desktop-only`` = "is-row-from-end-10-desktop-only"

    [<Literal>]
    let ``is-row-from-end-11-desktop-only`` = "is-row-from-end-11-desktop-only"

    [<Literal>]
    let ``is-row-from-end-12-desktop-only`` = "is-row-from-end-12-desktop-only"

    [<Literal>]
    let ``is-row-span-1-desktop-only`` = "is-row-span-1-desktop-only"

    [<Literal>]
    let ``is-row-span-2-desktop-only`` = "is-row-span-2-desktop-only"

    [<Literal>]
    let ``is-row-span-3-desktop-only`` = "is-row-span-3-desktop-only"

    [<Literal>]
    let ``is-row-span-4-desktop-only`` = "is-row-span-4-desktop-only"

    [<Literal>]
    let ``is-row-span-5-desktop-only`` = "is-row-span-5-desktop-only"

    [<Literal>]
    let ``is-row-span-6-desktop-only`` = "is-row-span-6-desktop-only"

    [<Literal>]
    let ``is-row-span-7-desktop-only`` = "is-row-span-7-desktop-only"

    [<Literal>]
    let ``is-row-span-8-desktop-only`` = "is-row-span-8-desktop-only"

    [<Literal>]
    let ``is-row-span-9-desktop-only`` = "is-row-span-9-desktop-only"

    [<Literal>]
    let ``is-row-span-10-desktop-only`` = "is-row-span-10-desktop-only"

    [<Literal>]
    let ``is-row-span-11-desktop-only`` = "is-row-span-11-desktop-only"

    [<Literal>]
    let ``is-row-span-12-desktop-only`` = "is-row-span-12-desktop-only"

    [<Literal>]
    let ``is-col-start-1-widescreen`` = "is-col-start-1-widescreen"

    [<Literal>]
    let ``is-col-start-2-widescreen`` = "is-col-start-2-widescreen"

    [<Literal>]
    let ``is-col-start-3-widescreen`` = "is-col-start-3-widescreen"

    [<Literal>]
    let ``is-col-start-4-widescreen`` = "is-col-start-4-widescreen"

    [<Literal>]
    let ``is-col-start-5-widescreen`` = "is-col-start-5-widescreen"

    [<Literal>]
    let ``is-col-start-6-widescreen`` = "is-col-start-6-widescreen"

    [<Literal>]
    let ``is-col-start-7-widescreen`` = "is-col-start-7-widescreen"

    [<Literal>]
    let ``is-col-start-8-widescreen`` = "is-col-start-8-widescreen"

    [<Literal>]
    let ``is-col-start-9-widescreen`` = "is-col-start-9-widescreen"

    [<Literal>]
    let ``is-col-start-10-widescreen`` = "is-col-start-10-widescreen"

    [<Literal>]
    let ``is-col-start-11-widescreen`` = "is-col-start-11-widescreen"

    [<Literal>]
    let ``is-col-start-12-widescreen`` = "is-col-start-12-widescreen"

    [<Literal>]
    let ``is-col-from-end-1-widescreen`` = "is-col-from-end-1-widescreen"

    [<Literal>]
    let ``is-col-from-end-2-widescreen`` = "is-col-from-end-2-widescreen"

    [<Literal>]
    let ``is-col-from-end-3-widescreen`` = "is-col-from-end-3-widescreen"

    [<Literal>]
    let ``is-col-from-end-4-widescreen`` = "is-col-from-end-4-widescreen"

    [<Literal>]
    let ``is-col-from-end-5-widescreen`` = "is-col-from-end-5-widescreen"

    [<Literal>]
    let ``is-col-from-end-6-widescreen`` = "is-col-from-end-6-widescreen"

    [<Literal>]
    let ``is-col-from-end-7-widescreen`` = "is-col-from-end-7-widescreen"

    [<Literal>]
    let ``is-col-from-end-8-widescreen`` = "is-col-from-end-8-widescreen"

    [<Literal>]
    let ``is-col-from-end-9-widescreen`` = "is-col-from-end-9-widescreen"

    [<Literal>]
    let ``is-col-from-end-10-widescreen`` = "is-col-from-end-10-widescreen"

    [<Literal>]
    let ``is-col-from-end-11-widescreen`` = "is-col-from-end-11-widescreen"

    [<Literal>]
    let ``is-col-from-end-12-widescreen`` = "is-col-from-end-12-widescreen"

    [<Literal>]
    let ``is-col-span-1-widescreen`` = "is-col-span-1-widescreen"

    [<Literal>]
    let ``is-col-span-2-widescreen`` = "is-col-span-2-widescreen"

    [<Literal>]
    let ``is-col-span-3-widescreen`` = "is-col-span-3-widescreen"

    [<Literal>]
    let ``is-col-span-4-widescreen`` = "is-col-span-4-widescreen"

    [<Literal>]
    let ``is-col-span-5-widescreen`` = "is-col-span-5-widescreen"

    [<Literal>]
    let ``is-col-span-6-widescreen`` = "is-col-span-6-widescreen"

    [<Literal>]
    let ``is-col-span-7-widescreen`` = "is-col-span-7-widescreen"

    [<Literal>]
    let ``is-col-span-8-widescreen`` = "is-col-span-8-widescreen"

    [<Literal>]
    let ``is-col-span-9-widescreen`` = "is-col-span-9-widescreen"

    [<Literal>]
    let ``is-col-span-10-widescreen`` = "is-col-span-10-widescreen"

    [<Literal>]
    let ``is-col-span-11-widescreen`` = "is-col-span-11-widescreen"

    [<Literal>]
    let ``is-col-span-12-widescreen`` = "is-col-span-12-widescreen"

    [<Literal>]
    let ``is-row-start-1-widescreen`` = "is-row-start-1-widescreen"

    [<Literal>]
    let ``is-row-start-2-widescreen`` = "is-row-start-2-widescreen"

    [<Literal>]
    let ``is-row-start-3-widescreen`` = "is-row-start-3-widescreen"

    [<Literal>]
    let ``is-row-start-4-widescreen`` = "is-row-start-4-widescreen"

    [<Literal>]
    let ``is-row-start-5-widescreen`` = "is-row-start-5-widescreen"

    [<Literal>]
    let ``is-row-start-6-widescreen`` = "is-row-start-6-widescreen"

    [<Literal>]
    let ``is-row-start-7-widescreen`` = "is-row-start-7-widescreen"

    [<Literal>]
    let ``is-row-start-8-widescreen`` = "is-row-start-8-widescreen"

    [<Literal>]
    let ``is-row-start-9-widescreen`` = "is-row-start-9-widescreen"

    [<Literal>]
    let ``is-row-start-10-widescreen`` = "is-row-start-10-widescreen"

    [<Literal>]
    let ``is-row-start-11-widescreen`` = "is-row-start-11-widescreen"

    [<Literal>]
    let ``is-row-start-12-widescreen`` = "is-row-start-12-widescreen"

    [<Literal>]
    let ``is-row-from-end-1-widescreen`` = "is-row-from-end-1-widescreen"

    [<Literal>]
    let ``is-row-from-end-2-widescreen`` = "is-row-from-end-2-widescreen"

    [<Literal>]
    let ``is-row-from-end-3-widescreen`` = "is-row-from-end-3-widescreen"

    [<Literal>]
    let ``is-row-from-end-4-widescreen`` = "is-row-from-end-4-widescreen"

    [<Literal>]
    let ``is-row-from-end-5-widescreen`` = "is-row-from-end-5-widescreen"

    [<Literal>]
    let ``is-row-from-end-6-widescreen`` = "is-row-from-end-6-widescreen"

    [<Literal>]
    let ``is-row-from-end-7-widescreen`` = "is-row-from-end-7-widescreen"

    [<Literal>]
    let ``is-row-from-end-8-widescreen`` = "is-row-from-end-8-widescreen"

    [<Literal>]
    let ``is-row-from-end-9-widescreen`` = "is-row-from-end-9-widescreen"

    [<Literal>]
    let ``is-row-from-end-10-widescreen`` = "is-row-from-end-10-widescreen"

    [<Literal>]
    let ``is-row-from-end-11-widescreen`` = "is-row-from-end-11-widescreen"

    [<Literal>]
    let ``is-row-from-end-12-widescreen`` = "is-row-from-end-12-widescreen"

    [<Literal>]
    let ``is-row-span-1-widescreen`` = "is-row-span-1-widescreen"

    [<Literal>]
    let ``is-row-span-2-widescreen`` = "is-row-span-2-widescreen"

    [<Literal>]
    let ``is-row-span-3-widescreen`` = "is-row-span-3-widescreen"

    [<Literal>]
    let ``is-row-span-4-widescreen`` = "is-row-span-4-widescreen"

    [<Literal>]
    let ``is-row-span-5-widescreen`` = "is-row-span-5-widescreen"

    [<Literal>]
    let ``is-row-span-6-widescreen`` = "is-row-span-6-widescreen"

    [<Literal>]
    let ``is-row-span-7-widescreen`` = "is-row-span-7-widescreen"

    [<Literal>]
    let ``is-row-span-8-widescreen`` = "is-row-span-8-widescreen"

    [<Literal>]
    let ``is-row-span-9-widescreen`` = "is-row-span-9-widescreen"

    [<Literal>]
    let ``is-row-span-10-widescreen`` = "is-row-span-10-widescreen"

    [<Literal>]
    let ``is-row-span-11-widescreen`` = "is-row-span-11-widescreen"

    [<Literal>]
    let ``is-row-span-12-widescreen`` = "is-row-span-12-widescreen"

    [<Literal>]
    let ``is-col-start-1-widescreen-only`` = "is-col-start-1-widescreen-only"

    [<Literal>]
    let ``is-col-start-2-widescreen-only`` = "is-col-start-2-widescreen-only"

    [<Literal>]
    let ``is-col-start-3-widescreen-only`` = "is-col-start-3-widescreen-only"

    [<Literal>]
    let ``is-col-start-4-widescreen-only`` = "is-col-start-4-widescreen-only"

    [<Literal>]
    let ``is-col-start-5-widescreen-only`` = "is-col-start-5-widescreen-only"

    [<Literal>]
    let ``is-col-start-6-widescreen-only`` = "is-col-start-6-widescreen-only"

    [<Literal>]
    let ``is-col-start-7-widescreen-only`` = "is-col-start-7-widescreen-only"

    [<Literal>]
    let ``is-col-start-8-widescreen-only`` = "is-col-start-8-widescreen-only"

    [<Literal>]
    let ``is-col-start-9-widescreen-only`` = "is-col-start-9-widescreen-only"

    [<Literal>]
    let ``is-col-start-10-widescreen-only`` = "is-col-start-10-widescreen-only"

    [<Literal>]
    let ``is-col-start-11-widescreen-only`` = "is-col-start-11-widescreen-only"

    [<Literal>]
    let ``is-col-start-12-widescreen-only`` = "is-col-start-12-widescreen-only"

    [<Literal>]
    let ``is-col-from-end-1-widescreen-only`` = "is-col-from-end-1-widescreen-only"

    [<Literal>]
    let ``is-col-from-end-2-widescreen-only`` = "is-col-from-end-2-widescreen-only"

    [<Literal>]
    let ``is-col-from-end-3-widescreen-only`` = "is-col-from-end-3-widescreen-only"

    [<Literal>]
    let ``is-col-from-end-4-widescreen-only`` = "is-col-from-end-4-widescreen-only"

    [<Literal>]
    let ``is-col-from-end-5-widescreen-only`` = "is-col-from-end-5-widescreen-only"

    [<Literal>]
    let ``is-col-from-end-6-widescreen-only`` = "is-col-from-end-6-widescreen-only"

    [<Literal>]
    let ``is-col-from-end-7-widescreen-only`` = "is-col-from-end-7-widescreen-only"

    [<Literal>]
    let ``is-col-from-end-8-widescreen-only`` = "is-col-from-end-8-widescreen-only"

    [<Literal>]
    let ``is-col-from-end-9-widescreen-only`` = "is-col-from-end-9-widescreen-only"

    [<Literal>]
    let ``is-col-from-end-10-widescreen-only`` = "is-col-from-end-10-widescreen-only"

    [<Literal>]
    let ``is-col-from-end-11-widescreen-only`` = "is-col-from-end-11-widescreen-only"

    [<Literal>]
    let ``is-col-from-end-12-widescreen-only`` = "is-col-from-end-12-widescreen-only"

    [<Literal>]
    let ``is-col-span-1-widescreen-only`` = "is-col-span-1-widescreen-only"

    [<Literal>]
    let ``is-col-span-2-widescreen-only`` = "is-col-span-2-widescreen-only"

    [<Literal>]
    let ``is-col-span-3-widescreen-only`` = "is-col-span-3-widescreen-only"

    [<Literal>]
    let ``is-col-span-4-widescreen-only`` = "is-col-span-4-widescreen-only"

    [<Literal>]
    let ``is-col-span-5-widescreen-only`` = "is-col-span-5-widescreen-only"

    [<Literal>]
    let ``is-col-span-6-widescreen-only`` = "is-col-span-6-widescreen-only"

    [<Literal>]
    let ``is-col-span-7-widescreen-only`` = "is-col-span-7-widescreen-only"

    [<Literal>]
    let ``is-col-span-8-widescreen-only`` = "is-col-span-8-widescreen-only"

    [<Literal>]
    let ``is-col-span-9-widescreen-only`` = "is-col-span-9-widescreen-only"

    [<Literal>]
    let ``is-col-span-10-widescreen-only`` = "is-col-span-10-widescreen-only"

    [<Literal>]
    let ``is-col-span-11-widescreen-only`` = "is-col-span-11-widescreen-only"

    [<Literal>]
    let ``is-col-span-12-widescreen-only`` = "is-col-span-12-widescreen-only"

    [<Literal>]
    let ``is-row-start-1-widescreen-only`` = "is-row-start-1-widescreen-only"

    [<Literal>]
    let ``is-row-start-2-widescreen-only`` = "is-row-start-2-widescreen-only"

    [<Literal>]
    let ``is-row-start-3-widescreen-only`` = "is-row-start-3-widescreen-only"

    [<Literal>]
    let ``is-row-start-4-widescreen-only`` = "is-row-start-4-widescreen-only"

    [<Literal>]
    let ``is-row-start-5-widescreen-only`` = "is-row-start-5-widescreen-only"

    [<Literal>]
    let ``is-row-start-6-widescreen-only`` = "is-row-start-6-widescreen-only"

    [<Literal>]
    let ``is-row-start-7-widescreen-only`` = "is-row-start-7-widescreen-only"

    [<Literal>]
    let ``is-row-start-8-widescreen-only`` = "is-row-start-8-widescreen-only"

    [<Literal>]
    let ``is-row-start-9-widescreen-only`` = "is-row-start-9-widescreen-only"

    [<Literal>]
    let ``is-row-start-10-widescreen-only`` = "is-row-start-10-widescreen-only"

    [<Literal>]
    let ``is-row-start-11-widescreen-only`` = "is-row-start-11-widescreen-only"

    [<Literal>]
    let ``is-row-start-12-widescreen-only`` = "is-row-start-12-widescreen-only"

    [<Literal>]
    let ``is-row-from-end-1-widescreen-only`` = "is-row-from-end-1-widescreen-only"

    [<Literal>]
    let ``is-row-from-end-2-widescreen-only`` = "is-row-from-end-2-widescreen-only"

    [<Literal>]
    let ``is-row-from-end-3-widescreen-only`` = "is-row-from-end-3-widescreen-only"

    [<Literal>]
    let ``is-row-from-end-4-widescreen-only`` = "is-row-from-end-4-widescreen-only"

    [<Literal>]
    let ``is-row-from-end-5-widescreen-only`` = "is-row-from-end-5-widescreen-only"

    [<Literal>]
    let ``is-row-from-end-6-widescreen-only`` = "is-row-from-end-6-widescreen-only"

    [<Literal>]
    let ``is-row-from-end-7-widescreen-only`` = "is-row-from-end-7-widescreen-only"

    [<Literal>]
    let ``is-row-from-end-8-widescreen-only`` = "is-row-from-end-8-widescreen-only"

    [<Literal>]
    let ``is-row-from-end-9-widescreen-only`` = "is-row-from-end-9-widescreen-only"

    [<Literal>]
    let ``is-row-from-end-10-widescreen-only`` = "is-row-from-end-10-widescreen-only"

    [<Literal>]
    let ``is-row-from-end-11-widescreen-only`` = "is-row-from-end-11-widescreen-only"

    [<Literal>]
    let ``is-row-from-end-12-widescreen-only`` = "is-row-from-end-12-widescreen-only"

    [<Literal>]
    let ``is-row-span-1-widescreen-only`` = "is-row-span-1-widescreen-only"

    [<Literal>]
    let ``is-row-span-2-widescreen-only`` = "is-row-span-2-widescreen-only"

    [<Literal>]
    let ``is-row-span-3-widescreen-only`` = "is-row-span-3-widescreen-only"

    [<Literal>]
    let ``is-row-span-4-widescreen-only`` = "is-row-span-4-widescreen-only"

    [<Literal>]
    let ``is-row-span-5-widescreen-only`` = "is-row-span-5-widescreen-only"

    [<Literal>]
    let ``is-row-span-6-widescreen-only`` = "is-row-span-6-widescreen-only"

    [<Literal>]
    let ``is-row-span-7-widescreen-only`` = "is-row-span-7-widescreen-only"

    [<Literal>]
    let ``is-row-span-8-widescreen-only`` = "is-row-span-8-widescreen-only"

    [<Literal>]
    let ``is-row-span-9-widescreen-only`` = "is-row-span-9-widescreen-only"

    [<Literal>]
    let ``is-row-span-10-widescreen-only`` = "is-row-span-10-widescreen-only"

    [<Literal>]
    let ``is-row-span-11-widescreen-only`` = "is-row-span-11-widescreen-only"

    [<Literal>]
    let ``is-row-span-12-widescreen-only`` = "is-row-span-12-widescreen-only"

    [<Literal>]
    let ``is-col-start-1-fullhd`` = "is-col-start-1-fullhd"

    [<Literal>]
    let ``is-col-start-2-fullhd`` = "is-col-start-2-fullhd"

    [<Literal>]
    let ``is-col-start-3-fullhd`` = "is-col-start-3-fullhd"

    [<Literal>]
    let ``is-col-start-4-fullhd`` = "is-col-start-4-fullhd"

    [<Literal>]
    let ``is-col-start-5-fullhd`` = "is-col-start-5-fullhd"

    [<Literal>]
    let ``is-col-start-6-fullhd`` = "is-col-start-6-fullhd"

    [<Literal>]
    let ``is-col-start-7-fullhd`` = "is-col-start-7-fullhd"

    [<Literal>]
    let ``is-col-start-8-fullhd`` = "is-col-start-8-fullhd"

    [<Literal>]
    let ``is-col-start-9-fullhd`` = "is-col-start-9-fullhd"

    [<Literal>]
    let ``is-col-start-10-fullhd`` = "is-col-start-10-fullhd"

    [<Literal>]
    let ``is-col-start-11-fullhd`` = "is-col-start-11-fullhd"

    [<Literal>]
    let ``is-col-start-12-fullhd`` = "is-col-start-12-fullhd"

    [<Literal>]
    let ``is-col-from-end-1-fullhd`` = "is-col-from-end-1-fullhd"

    [<Literal>]
    let ``is-col-from-end-2-fullhd`` = "is-col-from-end-2-fullhd"

    [<Literal>]
    let ``is-col-from-end-3-fullhd`` = "is-col-from-end-3-fullhd"

    [<Literal>]
    let ``is-col-from-end-4-fullhd`` = "is-col-from-end-4-fullhd"

    [<Literal>]
    let ``is-col-from-end-5-fullhd`` = "is-col-from-end-5-fullhd"

    [<Literal>]
    let ``is-col-from-end-6-fullhd`` = "is-col-from-end-6-fullhd"

    [<Literal>]
    let ``is-col-from-end-7-fullhd`` = "is-col-from-end-7-fullhd"

    [<Literal>]
    let ``is-col-from-end-8-fullhd`` = "is-col-from-end-8-fullhd"

    [<Literal>]
    let ``is-col-from-end-9-fullhd`` = "is-col-from-end-9-fullhd"

    [<Literal>]
    let ``is-col-from-end-10-fullhd`` = "is-col-from-end-10-fullhd"

    [<Literal>]
    let ``is-col-from-end-11-fullhd`` = "is-col-from-end-11-fullhd"

    [<Literal>]
    let ``is-col-from-end-12-fullhd`` = "is-col-from-end-12-fullhd"

    [<Literal>]
    let ``is-col-span-1-fullhd`` = "is-col-span-1-fullhd"

    [<Literal>]
    let ``is-col-span-2-fullhd`` = "is-col-span-2-fullhd"

    [<Literal>]
    let ``is-col-span-3-fullhd`` = "is-col-span-3-fullhd"

    [<Literal>]
    let ``is-col-span-4-fullhd`` = "is-col-span-4-fullhd"

    [<Literal>]
    let ``is-col-span-5-fullhd`` = "is-col-span-5-fullhd"

    [<Literal>]
    let ``is-col-span-6-fullhd`` = "is-col-span-6-fullhd"

    [<Literal>]
    let ``is-col-span-7-fullhd`` = "is-col-span-7-fullhd"

    [<Literal>]
    let ``is-col-span-8-fullhd`` = "is-col-span-8-fullhd"

    [<Literal>]
    let ``is-col-span-9-fullhd`` = "is-col-span-9-fullhd"

    [<Literal>]
    let ``is-col-span-10-fullhd`` = "is-col-span-10-fullhd"

    [<Literal>]
    let ``is-col-span-11-fullhd`` = "is-col-span-11-fullhd"

    [<Literal>]
    let ``is-col-span-12-fullhd`` = "is-col-span-12-fullhd"

    [<Literal>]
    let ``is-row-start-1-fullhd`` = "is-row-start-1-fullhd"

    [<Literal>]
    let ``is-row-start-2-fullhd`` = "is-row-start-2-fullhd"

    [<Literal>]
    let ``is-row-start-3-fullhd`` = "is-row-start-3-fullhd"

    [<Literal>]
    let ``is-row-start-4-fullhd`` = "is-row-start-4-fullhd"

    [<Literal>]
    let ``is-row-start-5-fullhd`` = "is-row-start-5-fullhd"

    [<Literal>]
    let ``is-row-start-6-fullhd`` = "is-row-start-6-fullhd"

    [<Literal>]
    let ``is-row-start-7-fullhd`` = "is-row-start-7-fullhd"

    [<Literal>]
    let ``is-row-start-8-fullhd`` = "is-row-start-8-fullhd"

    [<Literal>]
    let ``is-row-start-9-fullhd`` = "is-row-start-9-fullhd"

    [<Literal>]
    let ``is-row-start-10-fullhd`` = "is-row-start-10-fullhd"

    [<Literal>]
    let ``is-row-start-11-fullhd`` = "is-row-start-11-fullhd"

    [<Literal>]
    let ``is-row-start-12-fullhd`` = "is-row-start-12-fullhd"

    [<Literal>]
    let ``is-row-from-end-1-fullhd`` = "is-row-from-end-1-fullhd"

    [<Literal>]
    let ``is-row-from-end-2-fullhd`` = "is-row-from-end-2-fullhd"

    [<Literal>]
    let ``is-row-from-end-3-fullhd`` = "is-row-from-end-3-fullhd"

    [<Literal>]
    let ``is-row-from-end-4-fullhd`` = "is-row-from-end-4-fullhd"

    [<Literal>]
    let ``is-row-from-end-5-fullhd`` = "is-row-from-end-5-fullhd"

    [<Literal>]
    let ``is-row-from-end-6-fullhd`` = "is-row-from-end-6-fullhd"

    [<Literal>]
    let ``is-row-from-end-7-fullhd`` = "is-row-from-end-7-fullhd"

    [<Literal>]
    let ``is-row-from-end-8-fullhd`` = "is-row-from-end-8-fullhd"

    [<Literal>]
    let ``is-row-from-end-9-fullhd`` = "is-row-from-end-9-fullhd"

    [<Literal>]
    let ``is-row-from-end-10-fullhd`` = "is-row-from-end-10-fullhd"

    [<Literal>]
    let ``is-row-from-end-11-fullhd`` = "is-row-from-end-11-fullhd"

    [<Literal>]
    let ``is-row-from-end-12-fullhd`` = "is-row-from-end-12-fullhd"

    [<Literal>]
    let ``is-row-span-1-fullhd`` = "is-row-span-1-fullhd"

    [<Literal>]
    let ``is-row-span-2-fullhd`` = "is-row-span-2-fullhd"

    [<Literal>]
    let ``is-row-span-3-fullhd`` = "is-row-span-3-fullhd"

    [<Literal>]
    let ``is-row-span-4-fullhd`` = "is-row-span-4-fullhd"

    [<Literal>]
    let ``is-row-span-5-fullhd`` = "is-row-span-5-fullhd"

    [<Literal>]
    let ``is-row-span-6-fullhd`` = "is-row-span-6-fullhd"

    [<Literal>]
    let ``is-row-span-7-fullhd`` = "is-row-span-7-fullhd"

    [<Literal>]
    let ``is-row-span-8-fullhd`` = "is-row-span-8-fullhd"

    [<Literal>]
    let ``is-row-span-9-fullhd`` = "is-row-span-9-fullhd"

    [<Literal>]
    let ``is-row-span-10-fullhd`` = "is-row-span-10-fullhd"

    [<Literal>]
    let ``is-row-span-11-fullhd`` = "is-row-span-11-fullhd"

    [<Literal>]
    let ``is-row-span-12-fullhd`` = "is-row-span-12-fullhd"

    [<Literal>]
    let ``mt-0`` = "mt-0"

    [<Literal>]
    let ``mt-1`` = "mt-1"

    [<Literal>]
    let ``mt-2`` = "mt-2"

    [<Literal>]
    let ``mt-3`` = "mt-3"

    [<Literal>]
    let ``mt-4`` = "mt-4"

    [<Literal>]
    let ``mt-5`` = "mt-5"

    [<Literal>]
    let ``mt-6`` = "mt-6"

    [<Literal>]
    let ``mt-auto`` = "mt-auto"

    [<Literal>]
    let ``mr-0`` = "mr-0"

    [<Literal>]
    let ``mr-1`` = "mr-1"

    [<Literal>]
    let ``mr-2`` = "mr-2"

    [<Literal>]
    let ``mr-3`` = "mr-3"

    [<Literal>]
    let ``mr-4`` = "mr-4"

    [<Literal>]
    let ``mr-5`` = "mr-5"

    [<Literal>]
    let ``mr-6`` = "mr-6"

    [<Literal>]
    let ``mr-auto`` = "mr-auto"

    [<Literal>]
    let ``mb-0`` = "mb-0"

    [<Literal>]
    let ``mb-1`` = "mb-1"

    [<Literal>]
    let ``mb-2`` = "mb-2"

    [<Literal>]
    let ``mb-3`` = "mb-3"

    [<Literal>]
    let ``mb-4`` = "mb-4"

    [<Literal>]
    let ``mb-5`` = "mb-5"

    [<Literal>]
    let ``mb-6`` = "mb-6"

    [<Literal>]
    let ``mb-auto`` = "mb-auto"

    [<Literal>]
    let ``ml-0`` = "ml-0"

    [<Literal>]
    let ``ml-1`` = "ml-1"

    [<Literal>]
    let ``ml-2`` = "ml-2"

    [<Literal>]
    let ``ml-3`` = "ml-3"

    [<Literal>]
    let ``ml-4`` = "ml-4"

    [<Literal>]
    let ``ml-5`` = "ml-5"

    [<Literal>]
    let ``ml-6`` = "ml-6"

    [<Literal>]
    let ``ml-auto`` = "ml-auto"

    [<Literal>]
    let ``mx-0`` = "mx-0"

    [<Literal>]
    let ``mx-1`` = "mx-1"

    [<Literal>]
    let ``mx-2`` = "mx-2"

    [<Literal>]
    let ``mx-3`` = "mx-3"

    [<Literal>]
    let ``mx-4`` = "mx-4"

    [<Literal>]
    let ``mx-5`` = "mx-5"

    [<Literal>]
    let ``mx-6`` = "mx-6"

    [<Literal>]
    let ``mx-auto`` = "mx-auto"

    [<Literal>]
    let ``my-0`` = "my-0"

    [<Literal>]
    let ``my-1`` = "my-1"

    [<Literal>]
    let ``my-2`` = "my-2"

    [<Literal>]
    let ``my-3`` = "my-3"

    [<Literal>]
    let ``my-4`` = "my-4"

    [<Literal>]
    let ``my-5`` = "my-5"

    [<Literal>]
    let ``my-6`` = "my-6"

    [<Literal>]
    let ``my-auto`` = "my-auto"

    [<Literal>]
    let ``p-0`` = "p-0"

    [<Literal>]
    let ``p-1`` = "p-1"

    [<Literal>]
    let ``p-2`` = "p-2"

    [<Literal>]
    let ``p-3`` = "p-3"

    [<Literal>]
    let ``p-4`` = "p-4"

    [<Literal>]
    let ``p-5`` = "p-5"

    [<Literal>]
    let ``p-6`` = "p-6"

    [<Literal>]
    let ``p-auto`` = "p-auto"

    [<Literal>]
    let ``pt-0`` = "pt-0"

    [<Literal>]
    let ``pt-1`` = "pt-1"

    [<Literal>]
    let ``pt-2`` = "pt-2"

    [<Literal>]
    let ``pt-3`` = "pt-3"

    [<Literal>]
    let ``pt-4`` = "pt-4"

    [<Literal>]
    let ``pt-5`` = "pt-5"

    [<Literal>]
    let ``pt-6`` = "pt-6"

    [<Literal>]
    let ``pt-auto`` = "pt-auto"

    [<Literal>]
    let ``pr-0`` = "pr-0"

    [<Literal>]
    let ``pr-1`` = "pr-1"

    [<Literal>]
    let ``pr-2`` = "pr-2"

    [<Literal>]
    let ``pr-3`` = "pr-3"

    [<Literal>]
    let ``pr-4`` = "pr-4"

    [<Literal>]
    let ``pr-5`` = "pr-5"

    [<Literal>]
    let ``pr-6`` = "pr-6"

    [<Literal>]
    let ``pr-auto`` = "pr-auto"

    [<Literal>]
    let ``pb-0`` = "pb-0"

    [<Literal>]
    let ``pb-1`` = "pb-1"

    [<Literal>]
    let ``pb-2`` = "pb-2"

    [<Literal>]
    let ``pb-3`` = "pb-3"

    [<Literal>]
    let ``pb-4`` = "pb-4"

    [<Literal>]
    let ``pb-5`` = "pb-5"

    [<Literal>]
    let ``pb-6`` = "pb-6"

    [<Literal>]
    let ``pb-auto`` = "pb-auto"

    [<Literal>]
    let ``pl-0`` = "pl-0"

    [<Literal>]
    let ``pl-1`` = "pl-1"

    [<Literal>]
    let ``pl-2`` = "pl-2"

    [<Literal>]
    let ``pl-3`` = "pl-3"

    [<Literal>]
    let ``pl-4`` = "pl-4"

    [<Literal>]
    let ``pl-5`` = "pl-5"

    [<Literal>]
    let ``pl-6`` = "pl-6"

    [<Literal>]
    let ``pl-auto`` = "pl-auto"

    [<Literal>]
    let ``px-0`` = "px-0"

    [<Literal>]
    let ``px-1`` = "px-1"

    [<Literal>]
    let ``px-2`` = "px-2"

    [<Literal>]
    let ``px-3`` = "px-3"

    [<Literal>]
    let ``px-4`` = "px-4"

    [<Literal>]
    let ``px-5`` = "px-5"

    [<Literal>]
    let ``px-6`` = "px-6"

    [<Literal>]
    let ``px-auto`` = "px-auto"

    [<Literal>]
    let ``py-0`` = "py-0"

    [<Literal>]
    let ``py-1`` = "py-1"

    [<Literal>]
    let ``py-2`` = "py-2"

    [<Literal>]
    let ``py-3`` = "py-3"

    [<Literal>]
    let ``py-4`` = "py-4"

    [<Literal>]
    let ``py-5`` = "py-5"

    [<Literal>]
    let ``py-6`` = "py-6"

    [<Literal>]
    let ``py-auto`` = "py-auto"

[<Fable.Core.Erase>]
type helpers =
    static member inline isClearfix = PropertyBuilders.mkClass ClassLiterals.``is-clearfix``
    static member inline isPulledLeft = PropertyBuilders.mkClass ClassLiterals.``is-pulled-left``

    static member inline isPulledRight =
        PropertyBuilders.mkClass ClassLiterals.``is-pulled-right``

    static member inline isMarginless = PropertyBuilders.mkClass ClassLiterals.``is-marginless``
    static member inline isPaddingless = PropertyBuilders.mkClass ClassLiterals.``is-paddingless``
    static member inline isOverlay = PropertyBuilders.mkClass ClassLiterals.``is-overlay``
    static member inline isClipped = PropertyBuilders.mkClass ClassLiterals.``is-clipped``
    static member inline isRadiusless = PropertyBuilders.mkClass ClassLiterals.``is-radiusless``
    static member inline isShadowless = PropertyBuilders.mkClass ClassLiterals.``is-shadowless``

    static member inline isUnselectable =
        PropertyBuilders.mkClass ClassLiterals.``is-unselectable``

    static member inline isClickable = PropertyBuilders.mkClass ClassLiterals.``is-clickable``
    static member inline isRelative = PropertyBuilders.mkClass ClassLiterals.``is-relative``
    static member inline isInvisible = PropertyBuilders.mkClass ClassLiterals.``is-invisible``
    static member inline isHidden = PropertyBuilders.mkClass ClassLiterals.``is-hidden``

    static member inline isHiddenMobile =
        PropertyBuilders.mkClass ClassLiterals.``is-hidden-mobile``

    static member inline isHiddenTabletOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-hidden-tablet-only``

    static member inline isHiddenDesktopOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-hidden-desktop-only``

    static member inline isHiddenWidescreenOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-hidden-widescreen-only``

    static member inline isHiddenTouch =
        PropertyBuilders.mkClass ClassLiterals.``is-hidden-touch``

    static member inline isHiddenTablet =
        PropertyBuilders.mkClass ClassLiterals.``is-hidden-tablet``

    static member inline isHiddenDesktop =
        PropertyBuilders.mkClass ClassLiterals.``is-hidden-desktop``

    static member inline isHiddenWidescreen =
        PropertyBuilders.mkClass ClassLiterals.``is-hidden-widescreen``

    static member inline isHiddenFullhd =
        PropertyBuilders.mkClass ClassLiterals.``is-hidden-fullhd``

    static member inline isSrOnly = PropertyBuilders.mkClass ClassLiterals.``is-sr-only``
    static member inline isBlock = PropertyBuilders.mkClass ClassLiterals.``is-block``

    static member inline isBlockMobile =
        PropertyBuilders.mkClass ClassLiterals.``is-block-mobile``

    static member inline isBlockTabletOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-block-tablet-only``

    static member inline isBlockDesktopOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-block-desktop-only``

    static member inline isBlockWidescreenOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-block-widescreen-only``

    static member inline isBlockTouch = PropertyBuilders.mkClass ClassLiterals.``is-block-touch``

    static member inline isBlockTablet =
        PropertyBuilders.mkClass ClassLiterals.``is-block-tablet``

    static member inline isBlockDesktop =
        PropertyBuilders.mkClass ClassLiterals.``is-block-desktop``

    static member inline isBlockWidescreen =
        PropertyBuilders.mkClass ClassLiterals.``is-block-widescreen``

    static member inline isBlockFullhd =
        PropertyBuilders.mkClass ClassLiterals.``is-block-fullhd``

    static member inline isFlex = PropertyBuilders.mkClass ClassLiterals.``is-flex``
    static member inline isFlexMobile = PropertyBuilders.mkClass ClassLiterals.``is-flex-mobile``

    static member inline isFlexTabletOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-flex-tablet-only``

    static member inline isFlexDesktopOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-flex-desktop-only``

    static member inline isFlexWidescreenOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-flex-widescreen-only``

    static member inline isFlexTouch = PropertyBuilders.mkClass ClassLiterals.``is-flex-touch``
    static member inline isFlexTablet = PropertyBuilders.mkClass ClassLiterals.``is-flex-tablet``

    static member inline isFlexDesktop =
        PropertyBuilders.mkClass ClassLiterals.``is-flex-desktop``

    static member inline isFlexWidescreen =
        PropertyBuilders.mkClass ClassLiterals.``is-flex-widescreen``

    static member inline isFlexFullhd = PropertyBuilders.mkClass ClassLiterals.``is-flex-fullhd``

    static member inline isFlexDirectionRow =
        PropertyBuilders.mkClass ClassLiterals.``is-flex-direction-row``

    static member inline isFlexDirectionRowReverse =
        PropertyBuilders.mkClass ClassLiterals.``is-flex-direction-row-reverse``

    static member inline isFlexDirectionColumn =
        PropertyBuilders.mkClass ClassLiterals.``is-flex-direction-column``

    static member inline isFlexDirectionColumnReverse =
        PropertyBuilders.mkClass ClassLiterals.``is-flex-direction-column-reverse``

    static member inline isFlexWrapNoWrap =
        PropertyBuilders.mkClass ClassLiterals.``is-flex-wrap-nowrap``

    static member inline isFlexWrapWrap =
        PropertyBuilders.mkClass ClassLiterals.``is-flex-wrap-wrap``

    static member inline isFlexWrapWrapReverse =
        PropertyBuilders.mkClass ClassLiterals.``is-flex-wrap-wrap-reverse``

    static member inline isJustifyContentFlexStart =
        PropertyBuilders.mkClass ClassLiterals.``is-justify-content-flex-start``

    static member inline isJustifyContentFlexEnd =
        PropertyBuilders.mkClass ClassLiterals.``is-justify-content-flex-end``

    static member inline isJustifyContentCenter =
        PropertyBuilders.mkClass ClassLiterals.``is-justify-content-center``

    static member inline isJustifyContentSpaceBetween =
        PropertyBuilders.mkClass ClassLiterals.``is-justify-content-space-between``

    static member inline isJustifyContentSpaceAround =
        PropertyBuilders.mkClass ClassLiterals.``is-justify-content-space-around``

    static member inline isJustifyContentSpaceEvenly =
        PropertyBuilders.mkClass ClassLiterals.``is-justify-content-space-evenly``

    static member inline isJustifyContentStart =
        PropertyBuilders.mkClass ClassLiterals.``is-justify-content-start``

    static member inline isJustifyContentEnd =
        PropertyBuilders.mkClass ClassLiterals.``is-justify-content-end``

    static member inline isJustifyContentLeft =
        PropertyBuilders.mkClass ClassLiterals.``is-justify-content-left``

    static member inline isJustifyContentRight =
        PropertyBuilders.mkClass ClassLiterals.``is-justify-content-right``

    static member inline isAlignContentFlexStart =
        PropertyBuilders.mkClass ClassLiterals.``is-align-content-flex-start``

    static member inline isAlignContentFlexEnd =
        PropertyBuilders.mkClass ClassLiterals.``is-align-content-flex-end``

    static member inline isAlignContentCenter =
        PropertyBuilders.mkClass ClassLiterals.``is-align-content-center``

    static member inline isAlignContentSpaceBetween =
        PropertyBuilders.mkClass ClassLiterals.``is-align-content-space-between``

    [<Obsolete("Use the member without the typo `isAlignContentSpaceBetween`")>]
    static member inline isAlignContentSpaceBetweem =
        PropertyBuilders.mkClass ClassLiterals.``is-align-content-space-between``

    static member inline isAlignContentSpaceAround =
        PropertyBuilders.mkClass ClassLiterals.``is-align-content-space-around``

    static member inline isAlignContentSpaceEvenly =
        PropertyBuilders.mkClass ClassLiterals.``is-align-content-space-evenly``

    static member inline isAlignContentStretch =
        PropertyBuilders.mkClass ClassLiterals.``is-align-content-stretch``

    static member inline isAlignContentStart =
        PropertyBuilders.mkClass ClassLiterals.``is-align-content-start``

    static member inline isAlignContentEnd =
        PropertyBuilders.mkClass ClassLiterals.``is-align-content-end``

    static member inline isAlignContentBaseline =
        PropertyBuilders.mkClass ClassLiterals.``is-align-content-baseline``

    static member inline isAlignItemsStretch =
        PropertyBuilders.mkClass ClassLiterals.``is-align-items-stretch``

    static member inline isAlignItemsFlexStart =
        PropertyBuilders.mkClass ClassLiterals.``is-align-items-flex-start``

    static member inline isAlignItemsFlexEnd =
        PropertyBuilders.mkClass ClassLiterals.``is-align-items-flex-end``

    static member inline isAlignItemsCenter =
        PropertyBuilders.mkClass ClassLiterals.``is-align-items-center``

    static member inline isAlignItemsBaseline =
        PropertyBuilders.mkClass ClassLiterals.``is-align-items-baseline``

    static member inline isAlignItemsStart =
        PropertyBuilders.mkClass ClassLiterals.``is-align-items-start``

    static member inline isAlignItemsEnd =
        PropertyBuilders.mkClass ClassLiterals.``is-align-items-end``

    static member inline isAlignItemsSelfStart =
        PropertyBuilders.mkClass ClassLiterals.``is-align-items-self-start``

    static member inline isAlignItemsSelfEnd =
        PropertyBuilders.mkClass ClassLiterals.``is-align-items-self-end``

    static member inline isAlignSelfAuto =
        PropertyBuilders.mkClass ClassLiterals.``is-align-self-auto``

    static member inline isAlignSelfFlexStart =
        PropertyBuilders.mkClass ClassLiterals.``is-align-self-flex-start``

    static member inline isAlignSelfFlexEnd =
        PropertyBuilders.mkClass ClassLiterals.``is-align-self-flex-end``

    static member inline isAlignSelfCenter =
        PropertyBuilders.mkClass ClassLiterals.``is-align-self-center``

    static member inline isAlignSelfBaseline =
        PropertyBuilders.mkClass ClassLiterals.``is-align-self-baseline``

    static member inline isAlignSelfStretch =
        PropertyBuilders.mkClass ClassLiterals.``is-align-self-stretch``

    static member inline isFlexGrow0 = PropertyBuilders.mkClass ClassLiterals.``is-flex-grow-0``
    static member inline isFlexGrow1 = PropertyBuilders.mkClass ClassLiterals.``is-flex-grow-1``
    static member inline isFlexGrow2 = PropertyBuilders.mkClass ClassLiterals.``is-flex-grow-2``
    static member inline isFlexGrow3 = PropertyBuilders.mkClass ClassLiterals.``is-flex-grow-3``
    static member inline isFlexGrow4 = PropertyBuilders.mkClass ClassLiterals.``is-flex-grow-4``
    static member inline isFlexGrow5 = PropertyBuilders.mkClass ClassLiterals.``is-flex-grow-5``

    static member inline isFlexShrink0 =
        PropertyBuilders.mkClass ClassLiterals.``is-flex-shrink-0``

    static member inline isFlexShrink1 =
        PropertyBuilders.mkClass ClassLiterals.``is-flex-shrink-1``

    static member inline isFlexShrink2 =
        PropertyBuilders.mkClass ClassLiterals.``is-flex-shrink-2``

    static member inline isFlexShrink3 =
        PropertyBuilders.mkClass ClassLiterals.``is-flex-shrink-3``

    static member inline isFlexShrink4 =
        PropertyBuilders.mkClass ClassLiterals.``is-flex-shrink-4``

    static member inline isFlexShrink5 =
        PropertyBuilders.mkClass ClassLiterals.``is-flex-shrink-5``

    static member inline isInline = PropertyBuilders.mkClass ClassLiterals.``is-inline``

    static member inline isInlineMobile =
        PropertyBuilders.mkClass ClassLiterals.``is-inline-mobile``

    static member inline isInlineTabletOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-inline-tablet-only``

    static member inline isInlineDesktopOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-inline-desktop-only``

    static member inline isInlineWidescreenOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-inline-widescreen-only``

    static member inline isInlineTouch =
        PropertyBuilders.mkClass ClassLiterals.``is-inline-touch``

    static member inline isInlineTablet =
        PropertyBuilders.mkClass ClassLiterals.``is-inline-tablet``

    static member inline isInlineDesktop =
        PropertyBuilders.mkClass ClassLiterals.``is-inline-desktop``

    static member inline isInlineWidescreen =
        PropertyBuilders.mkClass ClassLiterals.``is-inline-widescreen``

    static member inline isInlineFullhd =
        PropertyBuilders.mkClass ClassLiterals.``is-inline-fullhd``

    static member inline isInlineBlock =
        PropertyBuilders.mkClass ClassLiterals.``is-inline-block``

    static member inline isInlineBlockMobile =
        PropertyBuilders.mkClass ClassLiterals.``is-inline-block-mobile``

    static member inline isInlineBlockTabletOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-inline-block-tablet-only``

    static member inline isInlineBlockDesktopOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-inline-block-desktop-only``

    static member inline isInlineBlockWidescreenOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-inline-block-widescreen-only``

    static member inline isInlineBlockTouch =
        PropertyBuilders.mkClass ClassLiterals.``is-inline-block-touch``

    static member inline isInlineBlockTablet =
        PropertyBuilders.mkClass ClassLiterals.``is-inline-block-tablet``

    static member inline isInlineBlockDesktop =
        PropertyBuilders.mkClass ClassLiterals.``is-inline-block-desktop``

    static member inline isInlineBlockWidescreen =
        PropertyBuilders.mkClass ClassLiterals.``is-inline-block-widescreen``

    static member inline isInlineBlockFullhd =
        PropertyBuilders.mkClass ClassLiterals.``is-inline-block-fullhd``

    static member inline isInlineFlex = PropertyBuilders.mkClass ClassLiterals.``is-inline-flex``

    static member inline isInlineFlexMobile =
        PropertyBuilders.mkClass ClassLiterals.``is-inline-flex-mobile``

    static member inline isInlineFlexTabletOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-inline-flex-tablet-only``

    static member inline isInlineFlexDesktopOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-inline-flex-desktop-only``

    static member inline isInlineFlexWidescreenOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-inline-flex-widescreen-only``

    static member inline isInlineFlexTouch =
        PropertyBuilders.mkClass ClassLiterals.``is-inline-flex-touch``

    static member inline isInlineFlexTablet =
        PropertyBuilders.mkClass ClassLiterals.``is-inline-flex-tablet``

    static member inline isInlineFlexDesktop =
        PropertyBuilders.mkClass ClassLiterals.``is-inline-flex-desktop``

    static member inline isInlineFlexWidescreen =
        PropertyBuilders.mkClass ClassLiterals.``is-inline-flex-widescreen``

    static member inline isInlineFlexFullhd =
        PropertyBuilders.mkClass ClassLiterals.``is-inline-flex-fullhd``

    static member inline isActive = PropertyBuilders.mkClass ClassLiterals.``is-active``
    static member inline isSkeleton = PropertyBuilders.mkClass ClassLiterals.``is-skeleton``
    static member inline hasSkeleton = PropertyBuilders.mkClass ClassLiterals.``has-skeleton``

[<Fable.Core.Erase>]
type size =
    static member inline isSize1 = PropertyBuilders.mkClass ClassLiterals.``is-size-1``
    static member inline isSize2 = PropertyBuilders.mkClass ClassLiterals.``is-size-2``
    static member inline isSize3 = PropertyBuilders.mkClass ClassLiterals.``is-size-3``
    static member inline isSize4 = PropertyBuilders.mkClass ClassLiterals.``is-size-4``
    static member inline isSize5 = PropertyBuilders.mkClass ClassLiterals.``is-size-5``
    static member inline isSize6 = PropertyBuilders.mkClass ClassLiterals.``is-size-6``
    static member inline isSize7 = PropertyBuilders.mkClass ClassLiterals.``is-size-7``

    static member inline isSize1Mobile =
        PropertyBuilders.mkClass ClassLiterals.``is-size-1-mobile``

    static member inline isSize2Mobile =
        PropertyBuilders.mkClass ClassLiterals.``is-size-2-mobile``

    static member inline isSize3Mobile =
        PropertyBuilders.mkClass ClassLiterals.``is-size-3-mobile``

    static member inline isSize4Mobile =
        PropertyBuilders.mkClass ClassLiterals.``is-size-4-mobile``

    static member inline isSize5Mobile =
        PropertyBuilders.mkClass ClassLiterals.``is-size-5-mobile``

    static member inline isSize6Mobile =
        PropertyBuilders.mkClass ClassLiterals.``is-size-6-mobile``

    static member inline isSize7Mobile =
        PropertyBuilders.mkClass ClassLiterals.``is-size-7-mobile``

    static member inline isSize1Tablet =
        PropertyBuilders.mkClass ClassLiterals.``is-size-1-tablet``

    static member inline isSize2Tablet =
        PropertyBuilders.mkClass ClassLiterals.``is-size-2-tablet``

    static member inline isSize3Tablet =
        PropertyBuilders.mkClass ClassLiterals.``is-size-3-tablet``

    static member inline isSize4Tablet =
        PropertyBuilders.mkClass ClassLiterals.``is-size-4-tablet``

    static member inline isSize5Tablet =
        PropertyBuilders.mkClass ClassLiterals.``is-size-5-tablet``

    static member inline isSize6Tablet =
        PropertyBuilders.mkClass ClassLiterals.``is-size-6-tablet``

    static member inline isSize7Tablet =
        PropertyBuilders.mkClass ClassLiterals.``is-size-7-tablet``

    static member inline isSize1Touch = PropertyBuilders.mkClass ClassLiterals.``is-size-1-touch``
    static member inline isSize2Touch = PropertyBuilders.mkClass ClassLiterals.``is-size-2-touch``
    static member inline isSize3Touch = PropertyBuilders.mkClass ClassLiterals.``is-size-3-touch``
    static member inline isSize4Touch = PropertyBuilders.mkClass ClassLiterals.``is-size-4-touch``
    static member inline isSize5Touch = PropertyBuilders.mkClass ClassLiterals.``is-size-5-touch``
    static member inline isSize6Touch = PropertyBuilders.mkClass ClassLiterals.``is-size-6-touch``
    static member inline isSize7Touch = PropertyBuilders.mkClass ClassLiterals.``is-size-7-touch``

    static member inline isSize1Desktop =
        PropertyBuilders.mkClass ClassLiterals.``is-size-1-desktop``

    static member inline isSize2Desktop =
        PropertyBuilders.mkClass ClassLiterals.``is-size-2-desktop``

    static member inline isSize3Desktop =
        PropertyBuilders.mkClass ClassLiterals.``is-size-3-desktop``

    static member inline isSize4Desktop =
        PropertyBuilders.mkClass ClassLiterals.``is-size-4-desktop``

    static member inline isSize5Desktop =
        PropertyBuilders.mkClass ClassLiterals.``is-size-5-desktop``

    static member inline isSize6Desktop =
        PropertyBuilders.mkClass ClassLiterals.``is-size-6-desktop``

    static member inline isSize7Desktop =
        PropertyBuilders.mkClass ClassLiterals.``is-size-7-desktop``

    static member inline isSize1Widescreen =
        PropertyBuilders.mkClass ClassLiterals.``is-size-1-widescreen``

    static member inline isSize2Widescreen =
        PropertyBuilders.mkClass ClassLiterals.``is-size-2-widescreen``

    static member inline isSize3Widescreen =
        PropertyBuilders.mkClass ClassLiterals.``is-size-3-widescreen``

    static member inline isSize4Widescreen =
        PropertyBuilders.mkClass ClassLiterals.``is-size-4-widescreen``

    static member inline isSize5Widescreen =
        PropertyBuilders.mkClass ClassLiterals.``is-size-5-widescreen``

    static member inline isSize6Widescreen =
        PropertyBuilders.mkClass ClassLiterals.``is-size-6-widescreen``

    static member inline isSize7Widescreen =
        PropertyBuilders.mkClass ClassLiterals.``is-size-7-widescreen``

    static member inline isSize1FullHd =
        PropertyBuilders.mkClass ClassLiterals.``is-size-1-fullhd``

    static member inline isSize2FullHd =
        PropertyBuilders.mkClass ClassLiterals.``is-size-2-fullhd``

    static member inline isSize3FullHd =
        PropertyBuilders.mkClass ClassLiterals.``is-size-3-fullhd``

    static member inline isSize4FullHd =
        PropertyBuilders.mkClass ClassLiterals.``is-size-4-fullhd``

    static member inline isSize5FullHd =
        PropertyBuilders.mkClass ClassLiterals.``is-size-5-fullhd``

    static member inline isSize6FullHd =
        PropertyBuilders.mkClass ClassLiterals.``is-size-6-fullhd``

    static member inline isSize7FullHd =
        PropertyBuilders.mkClass ClassLiterals.``is-size-7-fullhd``

[<Fable.Core.Erase>]
type spacing =
    static member inline m0 = PropertyBuilders.mkClass ClassLiterals.``m-0``
    static member inline m1 = PropertyBuilders.mkClass ClassLiterals.``m-1``
    static member inline m2 = PropertyBuilders.mkClass ClassLiterals.``m-2``
    static member inline m3 = PropertyBuilders.mkClass ClassLiterals.``m-3``
    static member inline m4 = PropertyBuilders.mkClass ClassLiterals.``m-4``
    static member inline m5 = PropertyBuilders.mkClass ClassLiterals.``m-5``
    static member inline m6 = PropertyBuilders.mkClass ClassLiterals.``m-6``
    static member inline ma = PropertyBuilders.mkClass ClassLiterals.``m-auto``
    static member inline mt0 = PropertyBuilders.mkClass ClassLiterals.``mt-0``
    static member inline mt1 = PropertyBuilders.mkClass ClassLiterals.``mt-1``
    static member inline mt2 = PropertyBuilders.mkClass ClassLiterals.``mt-2``
    static member inline mt3 = PropertyBuilders.mkClass ClassLiterals.``mt-3``
    static member inline mt4 = PropertyBuilders.mkClass ClassLiterals.``mt-4``
    static member inline mt5 = PropertyBuilders.mkClass ClassLiterals.``mt-5``
    static member inline mt6 = PropertyBuilders.mkClass ClassLiterals.``mt-6``
    static member inline mta = PropertyBuilders.mkClass ClassLiterals.``mt-auto``
    static member inline mr0 = PropertyBuilders.mkClass ClassLiterals.``mr-0``
    static member inline mr1 = PropertyBuilders.mkClass ClassLiterals.``mr-1``
    static member inline mr2 = PropertyBuilders.mkClass ClassLiterals.``mr-2``
    static member inline mr3 = PropertyBuilders.mkClass ClassLiterals.``mr-3``
    static member inline mr4 = PropertyBuilders.mkClass ClassLiterals.``mr-4``
    static member inline mr5 = PropertyBuilders.mkClass ClassLiterals.``mr-5``
    static member inline mr6 = PropertyBuilders.mkClass ClassLiterals.``mr-6``
    static member inline mra = PropertyBuilders.mkClass ClassLiterals.``mr-auto``
    static member inline mb0 = PropertyBuilders.mkClass ClassLiterals.``mb-0``
    static member inline mb1 = PropertyBuilders.mkClass ClassLiterals.``mb-1``
    static member inline mb2 = PropertyBuilders.mkClass ClassLiterals.``mb-2``
    static member inline mb3 = PropertyBuilders.mkClass ClassLiterals.``mb-3``
    static member inline mb4 = PropertyBuilders.mkClass ClassLiterals.``mb-4``
    static member inline mb5 = PropertyBuilders.mkClass ClassLiterals.``mb-5``
    static member inline mb6 = PropertyBuilders.mkClass ClassLiterals.``mb-6``
    static member inline mba = PropertyBuilders.mkClass ClassLiterals.``mb-auto``
    static member inline ml0 = PropertyBuilders.mkClass ClassLiterals.``ml-0``
    static member inline ml1 = PropertyBuilders.mkClass ClassLiterals.``ml-1``
    static member inline ml2 = PropertyBuilders.mkClass ClassLiterals.``ml-2``
    static member inline ml3 = PropertyBuilders.mkClass ClassLiterals.``ml-3``
    static member inline ml4 = PropertyBuilders.mkClass ClassLiterals.``ml-4``
    static member inline ml5 = PropertyBuilders.mkClass ClassLiterals.``ml-5``
    static member inline ml6 = PropertyBuilders.mkClass ClassLiterals.``ml-6``
    static member inline mla = PropertyBuilders.mkClass ClassLiterals.``ml-auto``
    static member inline mx0 = PropertyBuilders.mkClass ClassLiterals.``mx-0``
    static member inline mx1 = PropertyBuilders.mkClass ClassLiterals.``mx-1``
    static member inline mx2 = PropertyBuilders.mkClass ClassLiterals.``mx-2``
    static member inline mx3 = PropertyBuilders.mkClass ClassLiterals.``mx-3``
    static member inline mx4 = PropertyBuilders.mkClass ClassLiterals.``mx-4``
    static member inline mx5 = PropertyBuilders.mkClass ClassLiterals.``mx-5``
    static member inline mx6 = PropertyBuilders.mkClass ClassLiterals.``mx-6``
    static member inline mxa = PropertyBuilders.mkClass ClassLiterals.``mx-auto``
    static member inline my0 = PropertyBuilders.mkClass ClassLiterals.``my-0``
    static member inline my1 = PropertyBuilders.mkClass ClassLiterals.``my-1``
    static member inline my2 = PropertyBuilders.mkClass ClassLiterals.``my-2``
    static member inline my3 = PropertyBuilders.mkClass ClassLiterals.``my-3``
    static member inline my4 = PropertyBuilders.mkClass ClassLiterals.``my-4``
    static member inline my5 = PropertyBuilders.mkClass ClassLiterals.``my-5``
    static member inline my6 = PropertyBuilders.mkClass ClassLiterals.``my-6``
    static member inline mya = PropertyBuilders.mkClass ClassLiterals.``my-auto``
    static member inline p0 = PropertyBuilders.mkClass ClassLiterals.``p-0``
    static member inline p1 = PropertyBuilders.mkClass ClassLiterals.``p-1``
    static member inline p2 = PropertyBuilders.mkClass ClassLiterals.``p-2``
    static member inline p3 = PropertyBuilders.mkClass ClassLiterals.``p-3``
    static member inline p4 = PropertyBuilders.mkClass ClassLiterals.``p-4``
    static member inline p5 = PropertyBuilders.mkClass ClassLiterals.``p-5``
    static member inline p6 = PropertyBuilders.mkClass ClassLiterals.``p-6``
    static member inline pa = PropertyBuilders.mkClass ClassLiterals.``p-auto``
    static member inline pt0 = PropertyBuilders.mkClass ClassLiterals.``pt-0``
    static member inline pt1 = PropertyBuilders.mkClass ClassLiterals.``pt-1``
    static member inline pt2 = PropertyBuilders.mkClass ClassLiterals.``pt-2``
    static member inline pt3 = PropertyBuilders.mkClass ClassLiterals.``pt-3``
    static member inline pt4 = PropertyBuilders.mkClass ClassLiterals.``pt-4``
    static member inline pt5 = PropertyBuilders.mkClass ClassLiterals.``pt-5``
    static member inline pt6 = PropertyBuilders.mkClass ClassLiterals.``pt-6``
    static member inline pta = PropertyBuilders.mkClass ClassLiterals.``pt-auto``
    static member inline pr0 = PropertyBuilders.mkClass ClassLiterals.``pr-0``
    static member inline pr1 = PropertyBuilders.mkClass ClassLiterals.``pr-1``
    static member inline pr2 = PropertyBuilders.mkClass ClassLiterals.``pr-2``
    static member inline pr3 = PropertyBuilders.mkClass ClassLiterals.``pr-3``
    static member inline pr4 = PropertyBuilders.mkClass ClassLiterals.``pr-4``
    static member inline pr5 = PropertyBuilders.mkClass ClassLiterals.``pr-5``
    static member inline pr6 = PropertyBuilders.mkClass ClassLiterals.``pr-6``
    static member inline pra = PropertyBuilders.mkClass ClassLiterals.``pr-auto``
    static member inline pb0 = PropertyBuilders.mkClass ClassLiterals.``pb-0``
    static member inline pb1 = PropertyBuilders.mkClass ClassLiterals.``pb-1``
    static member inline pb2 = PropertyBuilders.mkClass ClassLiterals.``pb-2``
    static member inline pb3 = PropertyBuilders.mkClass ClassLiterals.``pb-3``
    static member inline pb4 = PropertyBuilders.mkClass ClassLiterals.``pb-4``
    static member inline pb5 = PropertyBuilders.mkClass ClassLiterals.``pb-5``
    static member inline pb6 = PropertyBuilders.mkClass ClassLiterals.``pb-6``
    static member inline pba = PropertyBuilders.mkClass ClassLiterals.``pb-auto``
    static member inline pl0 = PropertyBuilders.mkClass ClassLiterals.``pl-0``
    static member inline pl1 = PropertyBuilders.mkClass ClassLiterals.``pl-1``
    static member inline pl2 = PropertyBuilders.mkClass ClassLiterals.``pl-2``
    static member inline pl3 = PropertyBuilders.mkClass ClassLiterals.``pl-3``
    static member inline pl4 = PropertyBuilders.mkClass ClassLiterals.``pl-4``
    static member inline pl5 = PropertyBuilders.mkClass ClassLiterals.``pl-5``
    static member inline pl6 = PropertyBuilders.mkClass ClassLiterals.``pl-6``
    static member inline pla = PropertyBuilders.mkClass ClassLiterals.``pl-auto``
    static member inline px0 = PropertyBuilders.mkClass ClassLiterals.``px-0``
    static member inline px1 = PropertyBuilders.mkClass ClassLiterals.``px-1``
    static member inline px2 = PropertyBuilders.mkClass ClassLiterals.``px-2``
    static member inline px3 = PropertyBuilders.mkClass ClassLiterals.``px-3``
    static member inline px4 = PropertyBuilders.mkClass ClassLiterals.``px-4``
    static member inline px5 = PropertyBuilders.mkClass ClassLiterals.``px-5``
    static member inline px6 = PropertyBuilders.mkClass ClassLiterals.``px-6``
    static member inline pxa = PropertyBuilders.mkClass ClassLiterals.``px-auto``
    static member inline py0 = PropertyBuilders.mkClass ClassLiterals.``py-0``
    static member inline py1 = PropertyBuilders.mkClass ClassLiterals.``py-1``
    static member inline py2 = PropertyBuilders.mkClass ClassLiterals.``py-2``
    static member inline py3 = PropertyBuilders.mkClass ClassLiterals.``py-3``
    static member inline py4 = PropertyBuilders.mkClass ClassLiterals.``py-4``
    static member inline py5 = PropertyBuilders.mkClass ClassLiterals.``py-5``
    static member inline py6 = PropertyBuilders.mkClass ClassLiterals.``py-6``
    static member inline pya = PropertyBuilders.mkClass ClassLiterals.``py-auto``

[<Fable.Core.Erase>]
type text =
    static member inline isFamilySansSerif =
        PropertyBuilders.mkClass ClassLiterals.``is-family-sans-serif``

    static member inline isFamilyMonospace =
        PropertyBuilders.mkClass ClassLiterals.``is-family-monospace``

    static member inline isFamilyPrimary =
        PropertyBuilders.mkClass ClassLiterals.``is-family-primary``

    static member inline isFamilySecondary =
        PropertyBuilders.mkClass ClassLiterals.``is-family-secondary``

    static member inline isFamilyCode = PropertyBuilders.mkClass ClassLiterals.``is-family-code``

    static member inline isCapitalized = PropertyBuilders.mkClass ClassLiterals.``is-capitalized``
    static member inline isLowercase = PropertyBuilders.mkClass ClassLiterals.``is-lowercase``
    static member inline isUppercase = PropertyBuilders.mkClass ClassLiterals.``is-uppercase``
    static member inline isItalic = PropertyBuilders.mkClass ClassLiterals.``is-italic``
    static member inline isUnderlined = PropertyBuilders.mkClass ClassLiterals.``is-underlined``

    static member inline hasTextWeightLight =
        PropertyBuilders.mkClass ClassLiterals.``has-text-weight-light``

    static member inline hasTextWeightNormal =
        PropertyBuilders.mkClass ClassLiterals.``has-text-weight-normal``

    static member inline hasTextWeightMedium =
        PropertyBuilders.mkClass ClassLiterals.``has-text-weight-medium``

    static member inline hasTextWeightSemibold =
        PropertyBuilders.mkClass ClassLiterals.``has-text-weight-semibold``

    static member inline hasTextWeightBold =
        PropertyBuilders.mkClass ClassLiterals.``has-text-weight-bold``

    static member inline hasTextWeightExtraBold =
        PropertyBuilders.mkClass ClassLiterals.``has-text-weight-extrabold``

    static member inline hasTextCentered =
        PropertyBuilders.mkClass ClassLiterals.``has-text-centered``

    static member inline hasTextJustified =
        PropertyBuilders.mkClass ClassLiterals.``has-text-justified``

    static member inline hasTextLeft = PropertyBuilders.mkClass ClassLiterals.``has-text-left``
    static member inline hasTextRight = PropertyBuilders.mkClass ClassLiterals.``has-text-right``

    static member inline hasTextCenteredMobile =
        PropertyBuilders.mkClass ClassLiterals.``has-text-centered-mobile``

    static member inline hasTextJustifiedMobile =
        PropertyBuilders.mkClass ClassLiterals.``has-text-justified-mobile``

    static member inline hasTextLeftMobile =
        PropertyBuilders.mkClass ClassLiterals.``has-text-left-mobile``

    static member inline hasTextRightMobile =
        PropertyBuilders.mkClass ClassLiterals.``has-text-right-mobile``

    static member inline hasTextCenteredTablet =
        PropertyBuilders.mkClass ClassLiterals.``has-text-centered-tablet``

    static member inline hasTextJustifiedTablet =
        PropertyBuilders.mkClass ClassLiterals.``has-text-justified-tablet``

    static member inline hasTextLeftTablet =
        PropertyBuilders.mkClass ClassLiterals.``has-text-left-tablet``

    static member inline hasTextRightTablet =
        PropertyBuilders.mkClass ClassLiterals.``has-text-right-tablet``

    static member inline hasTextCenteredTabletOnly =
        PropertyBuilders.mkClass ClassLiterals.``has-text-centered-tablet-only``

    static member inline hasTextJustifiedTabletOnly =
        PropertyBuilders.mkClass ClassLiterals.``has-text-justified-tablet-only``

    static member inline hasTextLeftTabletOnly =
        PropertyBuilders.mkClass ClassLiterals.``has-text-left-tablet-only``

    static member inline hasTextRightTabletOnly =
        PropertyBuilders.mkClass ClassLiterals.``has-text-right-tablet-only``

    static member inline hasTextCenteredTouch =
        PropertyBuilders.mkClass ClassLiterals.``has-text-centered-touch``

    static member inline hasTextJustifiedTouch =
        PropertyBuilders.mkClass ClassLiterals.``has-text-justified-touch``

    static member inline hasTextLeftTouch =
        PropertyBuilders.mkClass ClassLiterals.``has-text-left-touch``

    static member inline hasTextRightTouch =
        PropertyBuilders.mkClass ClassLiterals.``has-text-right-touch``

    static member inline hasTextCenteredDesktop =
        PropertyBuilders.mkClass ClassLiterals.``has-text-centered-desktop``

    static member inline hasTextJustifiedDesktop =
        PropertyBuilders.mkClass ClassLiterals.``has-text-justified-desktop``

    static member inline hasTextLeftDesktop =
        PropertyBuilders.mkClass ClassLiterals.``has-text-left-desktop``

    static member inline hasTextRightDesktop =
        PropertyBuilders.mkClass ClassLiterals.``has-text-right-desktop``

    static member inline hasTextCenteredDesktopOnly =
        PropertyBuilders.mkClass ClassLiterals.``has-text-centered-desktop-only``

    static member inline hasTextJustifiedDesktopOnly =
        PropertyBuilders.mkClass ClassLiterals.``has-text-justified-desktop-only``

    static member inline hasTextLeftDesktopOnly =
        PropertyBuilders.mkClass ClassLiterals.``has-text-left-desktop-only``

    static member inline hasTextRightDesktopOnly =
        PropertyBuilders.mkClass ClassLiterals.``has-text-right-desktop-only``

    static member inline hasTextCenteredWidescreen =
        PropertyBuilders.mkClass ClassLiterals.``has-text-centered-widescreen``

    static member inline hasTextJustifiedWidescreen =
        PropertyBuilders.mkClass ClassLiterals.``has-text-justified-widescreen``

    static member inline hasTextLeftWidescreen =
        PropertyBuilders.mkClass ClassLiterals.``has-text-left-widescreen``

    static member inline hasTextRightWidescreen =
        PropertyBuilders.mkClass ClassLiterals.``has-text-right-widescreen``

    static member inline hasTextCenteredWidescreenOnly =
        PropertyBuilders.mkClass ClassLiterals.``has-text-centered-widescreen-only``

    static member inline hasTextJustifiedWidescreenOnly =
        PropertyBuilders.mkClass ClassLiterals.``has-text-justified-widescreen-only``

    static member inline hasTextLeftWidescreenOnly =
        PropertyBuilders.mkClass ClassLiterals.``has-text-left-widescreen-only``

    static member inline hasTextRightWidescreenOnly =
        PropertyBuilders.mkClass ClassLiterals.``has-text-right-widescreen-only``

    static member inline hasTextCenteredFullHd =
        PropertyBuilders.mkClass ClassLiterals.``has-text-centered-fullhd``

    static member inline hasTextJustifiedFullHd =
        PropertyBuilders.mkClass ClassLiterals.``has-text-justified-fullhd``

    static member inline hasTextLeftFullHd =
        PropertyBuilders.mkClass ClassLiterals.``has-text-left-fullhd``

    static member inline hasTextRightFullHd =
        PropertyBuilders.mkClass ClassLiterals.``has-text-right-fullhd``

[<Fable.Core.Erase>]
type color =
    static member inline isWhite = PropertyBuilders.mkClass ClassLiterals.``is-white``
    static member inline isBlack = PropertyBuilders.mkClass ClassLiterals.``is-black``
    static member inline isLight = PropertyBuilders.mkClass ClassLiterals.``is-light``
    static member inline isDark = PropertyBuilders.mkClass ClassLiterals.``is-dark``
    static member inline isPrimary = PropertyBuilders.mkClass ClassLiterals.``is-primary``
    static member inline isLink = PropertyBuilders.mkClass ClassLiterals.``is-link``
    static member inline isInfo = PropertyBuilders.mkClass ClassLiterals.``is-info``
    static member inline isSuccess = PropertyBuilders.mkClass ClassLiterals.``is-success``
    static member inline isWarning = PropertyBuilders.mkClass ClassLiterals.``is-warning``
    static member inline isDanger = PropertyBuilders.mkClass ClassLiterals.``is-danger``

    static member inline hasTextWhite = PropertyBuilders.mkClass ClassLiterals.``has-text-white``
    static member inline hasTextBlack = PropertyBuilders.mkClass ClassLiterals.``has-text-black``
    static member inline hasTextLight = PropertyBuilders.mkClass ClassLiterals.``has-text-light``
    static member inline hasTextDark = PropertyBuilders.mkClass ClassLiterals.``has-text-dark``
    static member inline hasTextText = PropertyBuilders.mkClass ClassLiterals.``has-text-text``

    static member inline hasTextTextInvert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-text-invert``

    static member inline hasTextTextLight =
        PropertyBuilders.mkClass ClassLiterals.``has-text-text-light``

    static member inline hasTextTextLightInvert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-text-light-invert``

    static member inline hasTextTextDark =
        PropertyBuilders.mkClass ClassLiterals.``has-text-text-dark``

    static member inline hasTextTextDarkInvert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-text-dark-invert``

    static member inline hasTextTextSoft =
        PropertyBuilders.mkClass ClassLiterals.``has-text-text-soft``

    static member inline hasTextTextSoftInvert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-text-soft-invert``

    static member inline hasTextTextBold =
        PropertyBuilders.mkClass ClassLiterals.``has-text-text-bold``

    static member inline hasTextTextBoldInvert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-text-bold-invert``

    static member inline hasTextTextOnScheme =
        PropertyBuilders.mkClass ClassLiterals.``has-text-text-on-scheme``

    static member inline hasTextTextOnSchemeInvert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-text-on-scheme-invert``

    static member inline hasTextText00 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-text-00``

    static member inline hasTextText00Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-text-00-invert``

    static member inline hasTextText05 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-text-05``

    static member inline hasTextText05Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-text-05-invert``

    static member inline hasTextText10 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-text-10``

    static member inline hasTextText10Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-text-10-invert``

    static member inline hasTextText15 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-text-15``

    static member inline hasTextText15Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-text-15-invert``

    static member inline hasTextText20 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-text-20``

    static member inline hasTextText20Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-text-20-invert``

    static member inline hasTextText25 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-text-25``

    static member inline hasTextText25Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-text-25-invert``

    static member inline hasTextText30 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-text-30``

    static member inline hasTextText30Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-text-30-invert``

    static member inline hasTextText35 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-text-35``

    static member inline hasTextText35Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-text-35-invert``

    static member inline hasTextText40 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-text-40``

    static member inline hasTextText40Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-text-40-invert``

    static member inline hasTextText45 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-text-45``

    static member inline hasTextText45Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-text-45-invert``

    static member inline hasTextText50 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-text-50``

    static member inline hasTextText50Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-text-50-invert``

    static member inline hasTextText55 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-text-55``

    static member inline hasTextText55Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-text-55-invert``

    static member inline hasTextText60 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-text-60``

    static member inline hasTextText60Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-text-60-invert``

    static member inline hasTextText65 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-text-65``

    static member inline hasTextText65Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-text-65-invert``

    static member inline hasTextText70 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-text-70``

    static member inline hasTextText70Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-text-70-invert``

    static member inline hasTextText75 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-text-75``

    static member inline hasTextText75Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-text-75-invert``

    static member inline hasTextText80 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-text-80``

    static member inline hasTextText80Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-text-80-invert``

    static member inline hasTextText85 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-text-85``

    static member inline hasTextText85Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-text-85-invert``

    static member inline hasTextText90 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-text-90``

    static member inline hasTextText90Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-text-90-invert``

    static member inline hasTextText95 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-text-95``

    static member inline hasTextText95Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-text-95-invert``

    static member inline hasTextText100 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-text-100``

    static member inline hasTextText100Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-text-100-invert``

    static member inline hasTextPrimary =
        PropertyBuilders.mkClass ClassLiterals.``has-text-primary``

    static member inline hasTextPrimaryInvert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-primary-invert``

    static member inline hasTextPrimaryLight =
        PropertyBuilders.mkClass ClassLiterals.``has-text-primary-light``

    static member inline hasTextPrimaryLightInvert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-primary-light-invert``

    static member inline hasTextPrimaryDark =
        PropertyBuilders.mkClass ClassLiterals.``has-text-primary-dark``

    static member inline hasTextPrimaryDarkInvert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-primary-dark-invert``

    static member inline hasTextPrimarySoft =
        PropertyBuilders.mkClass ClassLiterals.``has-text-primary-soft``

    static member inline hasTextPrimarySoftInvert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-primary-soft-invert``

    static member inline hasTextPrimaryBold =
        PropertyBuilders.mkClass ClassLiterals.``has-text-primary-bold``

    static member inline hasTextPrimaryBoldInvert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-primary-bold-invert``

    static member inline hasTextPrimaryOnScheme =
        PropertyBuilders.mkClass ClassLiterals.``has-text-primary-on-scheme``

    static member inline hasTextPrimaryOnSchemeInvert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-primary-on-scheme-invert``

    static member inline hasTextPrimary00 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-primary-00``

    static member inline hasTextPrimary00Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-primary-00-invert``

    static member inline hasTextPrimary05 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-primary-05``

    static member inline hasTextPrimary05Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-primary-05-invert``

    static member inline hasTextPrimary10 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-primary-10``

    static member inline hasTextPrimary10Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-primary-10-invert``

    static member inline hasTextPrimary15 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-primary-15``

    static member inline hasTextPrimary15Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-primary-15-invert``

    static member inline hasTextPrimary20 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-primary-20``

    static member inline hasTextPrimary20Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-primary-20-invert``

    static member inline hasTextPrimary25 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-primary-25``

    static member inline hasTextPrimary25Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-primary-25-invert``

    static member inline hasTextPrimary30 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-primary-30``

    static member inline hasTextPrimary30Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-primary-30-invert``

    static member inline hasTextPrimary35 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-primary-35``

    static member inline hasTextPrimary35Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-primary-35-invert``

    static member inline hasTextPrimary40 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-primary-40``

    static member inline hasTextPrimary40Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-primary-40-invert``

    static member inline hasTextPrimary45 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-primary-45``

    static member inline hasTextPrimary45Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-primary-45-invert``

    static member inline hasTextPrimary50 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-primary-50``

    static member inline hasTextPrimary50Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-primary-50-invert``

    static member inline hasTextPrimary55 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-primary-55``

    static member inline hasTextPrimary55Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-primary-55-invert``

    static member inline hasTextPrimary60 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-primary-60``

    static member inline hasTextPrimary60Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-primary-60-invert``

    static member inline hasTextPrimary65 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-primary-65``

    static member inline hasTextPrimary65Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-primary-65-invert``

    static member inline hasTextPrimary70 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-primary-70``

    static member inline hasTextPrimary70Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-primary-70-invert``

    static member inline hasTextPrimary75 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-primary-75``

    static member inline hasTextPrimary75Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-primary-75-invert``

    static member inline hasTextPrimary80 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-primary-80``

    static member inline hasTextPrimary80Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-primary-80-invert``

    static member inline hasTextPrimary85 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-primary-85``

    static member inline hasTextPrimary85Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-primary-85-invert``

    static member inline hasTextPrimary90 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-primary-90``

    static member inline hasTextPrimary90Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-primary-90-invert``

    static member inline hasTextPrimary95 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-primary-95``

    static member inline hasTextPrimary95Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-primary-95-invert``

    static member inline hasTextPrimary100 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-primary-100``

    static member inline hasTextPrimary100Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-primary-100-invert``

    static member inline hasTextInfo = PropertyBuilders.mkClass ClassLiterals.``has-text-info``

    static member inline hasTextInfoInvert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-info-invert``

    static member inline hasTextInfoLight =
        PropertyBuilders.mkClass ClassLiterals.``has-text-info-light``

    static member inline hasTextInfoLightInvert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-info-light-invert``

    static member inline hasTextInfoDark =
        PropertyBuilders.mkClass ClassLiterals.``has-text-info-dark``

    static member inline hasTextInfoDarkInvert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-info-dark-invert``

    static member inline hasTextInfoSoft =
        PropertyBuilders.mkClass ClassLiterals.``has-text-info-soft``

    static member inline hasTextInfoSoftInvert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-info-soft-invert``

    static member inline hasTextInfoBold =
        PropertyBuilders.mkClass ClassLiterals.``has-text-info-bold``

    static member inline hasTextInfoBoldInvert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-info-bold-invert``

    static member inline hasTextInfoOnScheme =
        PropertyBuilders.mkClass ClassLiterals.``has-text-info-on-scheme``

    static member inline hasTextInfoOnSchemeInvert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-info-on-scheme-invert``

    static member inline hasTextInfo00 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-info-00``

    static member inline hasTextInfo00Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-info-00-invert``

    static member inline hasTextInfo05 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-info-05``

    static member inline hasTextInfo05Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-info-05-invert``

    static member inline hasTextInfo10 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-info-10``

    static member inline hasTextInfo10Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-info-10-invert``

    static member inline hasTextInfo15 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-info-15``

    static member inline hasTextInfo15Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-info-15-invert``

    static member inline hasTextInfo20 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-info-20``

    static member inline hasTextInfo20Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-info-20-invert``

    static member inline hasTextInfo25 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-info-25``

    static member inline hasTextInfo25Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-info-25-invert``

    static member inline hasTextInfo30 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-info-30``

    static member inline hasTextInfo30Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-info-30-invert``

    static member inline hasTextInfo35 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-info-35``

    static member inline hasTextInfo35Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-info-35-invert``

    static member inline hasTextInfo40 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-info-40``

    static member inline hasTextInfo40Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-info-40-invert``

    static member inline hasTextInfo45 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-info-45``

    static member inline hasTextInfo45Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-info-45-invert``

    static member inline hasTextInfo50 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-info-50``

    static member inline hasTextInfo50Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-info-50-invert``

    static member inline hasTextInfo55 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-info-55``

    static member inline hasTextInfo55Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-info-55-invert``

    static member inline hasTextInfo60 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-info-60``

    static member inline hasTextInfo60Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-info-60-invert``

    static member inline hasTextInfo65 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-info-65``

    static member inline hasTextInfo65Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-info-65-invert``

    static member inline hasTextInfo70 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-info-70``

    static member inline hasTextInfo70Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-info-70-invert``

    static member inline hasTextInfo75 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-info-75``

    static member inline hasTextInfo75Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-info-75-invert``

    static member inline hasTextInfo80 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-info-80``

    static member inline hasTextInfo80Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-info-80-invert``

    static member inline hasTextInfo85 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-info-85``

    static member inline hasTextInfo85Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-info-85-invert``

    static member inline hasTextInfo90 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-info-90``

    static member inline hasTextInfo90Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-info-90-invert``

    static member inline hasTextInfo95 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-info-95``

    static member inline hasTextInfo95Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-info-95-invert``

    static member inline hasTextInfo100 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-info-100``

    static member inline hasTextInfo100Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-info-100-invert``

    static member inline hasTextLink = PropertyBuilders.mkClass ClassLiterals.``has-text-link``

    static member inline hasTextLinkInvert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-link-invert``

    static member inline hasTextLinkLight =
        PropertyBuilders.mkClass ClassLiterals.``has-text-link-light``

    static member inline hasTextLinkLightInvert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-link-light-invert``

    static member inline hasTextLinkDark =
        PropertyBuilders.mkClass ClassLiterals.``has-text-link-dark``

    static member inline hasTextLinkDarkInvert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-link-dark-invert``

    static member inline hasTextLinkSoft =
        PropertyBuilders.mkClass ClassLiterals.``has-text-link-soft``

    static member inline hasTextLinkSoftInvert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-link-soft-invert``

    static member inline hasTextLinkBold =
        PropertyBuilders.mkClass ClassLiterals.``has-text-link-bold``

    static member inline hasTextLinkBoldInvert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-link-bold-invert``

    static member inline hasTextLinkOnScheme =
        PropertyBuilders.mkClass ClassLiterals.``has-text-link-on-scheme``

    static member inline hasTextLinkOnSchemeInvert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-link-on-scheme-invert``

    static member inline hasTextLink00 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-link-00``

    static member inline hasTextLink00Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-link-00-invert``

    static member inline hasTextLink05 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-link-05``

    static member inline hasTextLink05Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-link-05-invert``

    static member inline hasTextLink10 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-link-10``

    static member inline hasTextLink10Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-link-10-invert``

    static member inline hasTextLink15 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-link-15``

    static member inline hasTextLink15Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-link-15-invert``

    static member inline hasTextLink20 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-link-20``

    static member inline hasTextLink20Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-link-20-invert``

    static member inline hasTextLink25 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-link-25``

    static member inline hasTextLink25Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-link-25-invert``

    static member inline hasTextLink30 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-link-30``

    static member inline hasTextLink30Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-link-30-invert``

    static member inline hasTextLink35 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-link-35``

    static member inline hasTextLink35Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-link-35-invert``

    static member inline hasTextLink40 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-link-40``

    static member inline hasTextLink40Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-link-40-invert``

    static member inline hasTextLink45 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-link-45``

    static member inline hasTextLink45Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-link-45-invert``

    static member inline hasTextLink50 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-link-50``

    static member inline hasTextLink50Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-link-50-invert``

    static member inline hasTextLink55 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-link-55``

    static member inline hasTextLink55Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-link-55-invert``

    static member inline hasTextLink60 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-link-60``

    static member inline hasTextLink60Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-link-60-invert``

    static member inline hasTextLink65 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-link-65``

    static member inline hasTextLink65Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-link-65-invert``

    static member inline hasTextLink70 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-link-70``

    static member inline hasTextLink70Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-link-70-invert``

    static member inline hasTextLink75 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-link-75``

    static member inline hasTextLink75Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-link-75-invert``

    static member inline hasTextLink80 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-link-80``

    static member inline hasTextLink80Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-link-80-invert``

    static member inline hasTextLink85 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-link-85``

    static member inline hasTextLink85Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-link-85-invert``

    static member inline hasTextLink90 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-link-90``

    static member inline hasTextLink90Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-link-90-invert``

    static member inline hasTextLink95 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-link-95``

    static member inline hasTextLink95Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-link-95-invert``

    static member inline hasTextLink100 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-link-100``

    static member inline hasTextLink100Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-link-100-invert``

    static member inline hasTextSuccess =
        PropertyBuilders.mkClass ClassLiterals.``has-text-success``

    static member inline hasTextSuccessInvert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-success-invert``

    static member inline hasTextSuccessLight =
        PropertyBuilders.mkClass ClassLiterals.``has-text-success-light``

    static member inline hasTextSuccessLightInvert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-success-light-invert``

    static member inline hasTextSuccessDark =
        PropertyBuilders.mkClass ClassLiterals.``has-text-success-dark``

    static member inline hasTextSuccessDarkInvert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-success-dark-invert``

    static member inline hasTextSuccessSoft =
        PropertyBuilders.mkClass ClassLiterals.``has-text-success-soft``

    static member inline hasTextSuccessSoftInvert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-success-soft-invert``

    static member inline hasTextSuccessBold =
        PropertyBuilders.mkClass ClassLiterals.``has-text-success-bold``

    static member inline hasTextSuccessBoldInvert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-success-bold-invert``

    static member inline hasTextSuccessOnScheme =
        PropertyBuilders.mkClass ClassLiterals.``has-text-success-on-scheme``

    static member inline hasTextSuccessOnSchemeInvert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-success-on-scheme-invert``

    static member inline hasTextSuccess00 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-success-00``

    static member inline hasTextSuccess00Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-success-00-invert``

    static member inline hasTextSuccess05 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-success-05``

    static member inline hasTextSuccess05Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-success-05-invert``

    static member inline hasTextSuccess10 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-success-10``

    static member inline hasTextSuccess10Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-success-10-invert``

    static member inline hasTextSuccess15 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-success-15``

    static member inline hasTextSuccess15Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-success-15-invert``

    static member inline hasTextSuccess20 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-success-20``

    static member inline hasTextSuccess20Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-success-20-invert``

    static member inline hasTextSuccess25 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-success-25``

    static member inline hasTextSuccess25Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-success-25-invert``

    static member inline hasTextSuccess30 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-success-30``

    static member inline hasTextSuccess30Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-success-30-invert``

    static member inline hasTextSuccess35 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-success-35``

    static member inline hasTextSuccess35Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-success-35-invert``

    static member inline hasTextSuccess40 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-success-40``

    static member inline hasTextSuccess40Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-success-40-invert``

    static member inline hasTextSuccess45 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-success-45``

    static member inline hasTextSuccess45Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-success-45-invert``

    static member inline hasTextSuccess50 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-success-50``

    static member inline hasTextSuccess50Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-success-50-invert``

    static member inline hasTextSuccess55 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-success-55``

    static member inline hasTextSuccess55Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-success-55-invert``

    static member inline hasTextSuccess60 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-success-60``

    static member inline hasTextSuccess60Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-success-60-invert``

    static member inline hasTextSuccess65 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-success-65``

    static member inline hasTextSuccess65Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-success-65-invert``

    static member inline hasTextSuccess70 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-success-70``

    static member inline hasTextSuccess70Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-success-70-invert``

    static member inline hasTextSuccess75 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-success-75``

    static member inline hasTextSuccess75Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-success-75-invert``

    static member inline hasTextSuccess80 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-success-80``

    static member inline hasTextSuccess80Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-success-80-invert``

    static member inline hasTextSuccess85 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-success-85``

    static member inline hasTextSuccess85Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-success-85-invert``

    static member inline hasTextSuccess90 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-success-90``

    static member inline hasTextSuccess90Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-success-90-invert``

    static member inline hasTextSuccess95 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-success-95``

    static member inline hasTextSuccess95Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-success-95-invert``

    static member inline hasTextSuccess100 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-success-100``

    static member inline hasTextSuccess100Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-success-100-invert``

    static member inline hasTextWarning =
        PropertyBuilders.mkClass ClassLiterals.``has-text-warning``

    static member inline hasTextWarningInvert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-warning-invert``

    static member inline hasTextWarningLight =
        PropertyBuilders.mkClass ClassLiterals.``has-text-warning-light``

    static member inline hasTextWarningLightInvert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-warning-light-invert``

    static member inline hasTextWarningDark =
        PropertyBuilders.mkClass ClassLiterals.``has-text-warning-dark``

    static member inline hasTextWarningDarkInvert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-warning-dark-invert``

    static member inline hasTextWarningSoft =
        PropertyBuilders.mkClass ClassLiterals.``has-text-warning-soft``

    static member inline hasTextWarningSoftInvert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-warning-soft-invert``

    static member inline hasTextWarningBold =
        PropertyBuilders.mkClass ClassLiterals.``has-text-warning-bold``

    static member inline hasTextWarningBoldInvert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-warning-bold-invert``

    static member inline hasTextWarningOnScheme =
        PropertyBuilders.mkClass ClassLiterals.``has-text-warning-on-scheme``

    static member inline hasTextWarningOnSchemeInvert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-warning-on-scheme-invert``

    static member inline hasTextWarning00 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-warning-00``

    static member inline hasTextWarning00Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-warning-00-invert``

    static member inline hasTextWarning05 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-warning-05``

    static member inline hasTextWarning05Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-warning-05-invert``

    static member inline hasTextWarning10 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-warning-10``

    static member inline hasTextWarning10Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-warning-10-invert``

    static member inline hasTextWarning15 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-warning-15``

    static member inline hasTextWarning15Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-warning-15-invert``

    static member inline hasTextWarning20 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-warning-20``

    static member inline hasTextWarning20Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-warning-20-invert``

    static member inline hasTextWarning25 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-warning-25``

    static member inline hasTextWarning25Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-warning-25-invert``

    static member inline hasTextWarning30 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-warning-30``

    static member inline hasTextWarning30Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-warning-30-invert``

    static member inline hasTextWarning35 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-warning-35``

    static member inline hasTextWarning35Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-warning-35-invert``

    static member inline hasTextWarning40 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-warning-40``

    static member inline hasTextWarning40Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-warning-40-invert``

    static member inline hasTextWarning45 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-warning-45``

    static member inline hasTextWarning45Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-warning-45-invert``

    static member inline hasTextWarning50 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-warning-50``

    static member inline hasTextWarning50Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-warning-50-invert``

    static member inline hasTextWarning55 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-warning-55``

    static member inline hasTextWarning55Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-warning-55-invert``

    static member inline hasTextWarning60 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-warning-60``

    static member inline hasTextWarning60Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-warning-60-invert``

    static member inline hasTextWarning65 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-warning-65``

    static member inline hasTextWarning65Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-warning-65-invert``

    static member inline hasTextWarning70 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-warning-70``

    static member inline hasTextWarning70Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-warning-70-invert``

    static member inline hasTextWarning75 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-warning-75``

    static member inline hasTextWarning75Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-warning-75-invert``

    static member inline hasTextWarning80 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-warning-80``

    static member inline hasTextWarning80Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-warning-80-invert``

    static member inline hasTextWarning85 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-warning-85``

    static member inline hasTextWarning85Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-warning-85-invert``

    static member inline hasTextWarning90 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-warning-90``

    static member inline hasTextWarning90Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-warning-90-invert``

    static member inline hasTextWarning95 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-warning-95``

    static member inline hasTextWarning95Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-warning-95-invert``

    static member inline hasTextWarning100 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-warning-100``

    static member inline hasTextWarning100Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-warning-100-invert``

    static member inline hasTextDanger =
        PropertyBuilders.mkClass ClassLiterals.``has-text-danger``

    static member inline hasTextDangerInvert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-danger-invert``

    static member inline hasTextDangerLight =
        PropertyBuilders.mkClass ClassLiterals.``has-text-danger-light``

    static member inline hasTextDangerLightInvert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-danger-light-invert``

    static member inline hasTextDangerDark =
        PropertyBuilders.mkClass ClassLiterals.``has-text-danger-dark``

    static member inline hasTextDangerDarkInvert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-danger-dark-invert``

    static member inline hasTextDangerSoft =
        PropertyBuilders.mkClass ClassLiterals.``has-text-danger-soft``

    static member inline hasTextDangerSoftInvert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-danger-soft-invert``

    static member inline hasTextDangerBold =
        PropertyBuilders.mkClass ClassLiterals.``has-text-danger-bold``

    static member inline hasTextDangerBoldInvert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-danger-bold-invert``

    static member inline hasTextDangerOnScheme =
        PropertyBuilders.mkClass ClassLiterals.``has-text-danger-on-scheme``

    static member inline hasTextDangerOnSchemeInvert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-danger-on-scheme-invert``

    static member inline hasTextDanger00 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-danger-00``

    static member inline hasTextDanger00Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-danger-00-invert``

    static member inline hasTextDanger05 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-danger-05``

    static member inline hasTextDanger05Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-danger-05-invert``

    static member inline hasTextDanger10 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-danger-10``

    static member inline hasTextDanger10Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-danger-10-invert``

    static member inline hasTextDanger15 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-danger-15``

    static member inline hasTextDanger15Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-danger-15-invert``

    static member inline hasTextDanger20 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-danger-20``

    static member inline hasTextDanger20Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-danger-20-invert``

    static member inline hasTextDanger25 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-danger-25``

    static member inline hasTextDanger25Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-danger-25-invert``

    static member inline hasTextDanger30 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-danger-30``

    static member inline hasTextDanger30Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-danger-30-invert``

    static member inline hasTextDanger35 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-danger-35``

    static member inline hasTextDanger35Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-danger-35-invert``

    static member inline hasTextDanger40 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-danger-40``

    static member inline hasTextDanger40Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-danger-40-invert``

    static member inline hasTextDanger45 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-danger-45``

    static member inline hasTextDanger45Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-danger-45-invert``

    static member inline hasTextDanger50 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-danger-50``

    static member inline hasTextDanger50Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-danger-50-invert``

    static member inline hasTextDanger55 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-danger-55``

    static member inline hasTextDanger55Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-danger-55-invert``

    static member inline hasTextDanger60 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-danger-60``

    static member inline hasTextDanger60Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-danger-60-invert``

    static member inline hasTextDanger65 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-danger-65``

    static member inline hasTextDanger65Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-danger-65-invert``

    static member inline hasTextDanger70 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-danger-70``

    static member inline hasTextDanger70Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-danger-70-invert``

    static member inline hasTextDanger75 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-danger-75``

    static member inline hasTextDanger75Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-danger-75-invert``

    static member inline hasTextDanger80 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-danger-80``

    static member inline hasTextDanger80Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-danger-80-invert``

    static member inline hasTextDanger85 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-danger-85``

    static member inline hasTextDanger85Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-danger-85-invert``

    static member inline hasTextDanger90 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-danger-90``

    static member inline hasTextDanger90Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-danger-90-invert``

    static member inline hasTextDanger95 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-danger-95``

    static member inline hasTextDanger95Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-danger-95-invert``

    static member inline hasTextDanger100 =
        PropertyBuilders.mkClass ClassLiterals.``has-text-danger-100``

    static member inline hasTextDanger100Invert =
        PropertyBuilders.mkClass ClassLiterals.``has-text-danger-100-invert``

    static member inline hasTextBlackBis =
        PropertyBuilders.mkClass ClassLiterals.``has-text-black-bis``

    static member inline hasTextBlackTer =
        PropertyBuilders.mkClass ClassLiterals.``has-text-black-ter``

    static member inline hasTextGreyDarker =
        PropertyBuilders.mkClass ClassLiterals.``has-text-grey-darker``

    static member inline hasTextGreyDark =
        PropertyBuilders.mkClass ClassLiterals.``has-text-grey-dark``

    static member inline hasTextGrey = PropertyBuilders.mkClass ClassLiterals.``has-text-grey``

    static member inline hasTextGreyLight =
        PropertyBuilders.mkClass ClassLiterals.``has-text-grey-light``

    static member inline hasTextGreyLighter =
        PropertyBuilders.mkClass ClassLiterals.``has-text-grey-lighter``

    static member inline hasTextWhiteTer =
        PropertyBuilders.mkClass ClassLiterals.``has-text-white-ter``

    static member inline hasTextWhiteBis =
        PropertyBuilders.mkClass ClassLiterals.``has-text-white-bis``

    static member inline hasTextCurrent =
        PropertyBuilders.mkClass ClassLiterals.``has-text-current``

    static member inline hasTextInherit =
        PropertyBuilders.mkClass ClassLiterals.``has-text-inherit``

    static member inline hasBackgroundWhite =
        PropertyBuilders.mkClass ClassLiterals.``has-background-white``

    static member inline hasBackgroundBlack =
        PropertyBuilders.mkClass ClassLiterals.``has-background-black``

    static member inline hasBackgroundLight =
        PropertyBuilders.mkClass ClassLiterals.``has-background-light``

    static member inline hasBackgroundDark =
        PropertyBuilders.mkClass ClassLiterals.``has-background-dark``

    static member inline hasBackgroundText =
        PropertyBuilders.mkClass ClassLiterals.``has-background-text``

    static member inline hasBackgroundPrimary =
        PropertyBuilders.mkClass ClassLiterals.``has-background-primary``

    static member inline hasBackgroundInfo =
        PropertyBuilders.mkClass ClassLiterals.``has-background-info``

    static member inline hasBackgroundLink =
        PropertyBuilders.mkClass ClassLiterals.``has-background-link``

    static member inline hasBackgroundSuccess =
        PropertyBuilders.mkClass ClassLiterals.``has-background-success``

    static member inline hasBackgroundWarning =
        PropertyBuilders.mkClass ClassLiterals.``has-background-warning``

    static member inline hasBackgroundDanger =
        PropertyBuilders.mkClass ClassLiterals.``has-background-danger``

    static member inline hasBackgroundBlackBis =
        PropertyBuilders.mkClass ClassLiterals.``has-background-black-bis``

    static member inline hasBackgroundBlackTer =
        PropertyBuilders.mkClass ClassLiterals.``has-background-black-ter``

    static member inline hasBackgroundGreyDarker =
        PropertyBuilders.mkClass ClassLiterals.``has-background-grey-darker``

    static member inline hasBackgroundGreyDark =
        PropertyBuilders.mkClass ClassLiterals.``has-background-grey-dark``

    static member inline hasBackgroundGrey =
        PropertyBuilders.mkClass ClassLiterals.``has-background-grey``

    static member inline hasBackgroundGreyLight =
        PropertyBuilders.mkClass ClassLiterals.``has-background-grey-light``

    static member inline hasBackgroundGreyLighter =
        PropertyBuilders.mkClass ClassLiterals.``has-background-grey-lighter``

    static member inline hasBackgroundWhiteTer =
        PropertyBuilders.mkClass ClassLiterals.``has-background-white-ter``

    static member inline hasBackgroundWhiteBis =
        PropertyBuilders.mkClass ClassLiterals.``has-background-white-bis``

    static member inline hasBackgroundTextInvert =
        PropertyBuilders.mkClass ClassLiterals.``has-background-text-invert``

    static member inline hasBackgroundPrimaryInvert =
        PropertyBuilders.mkClass ClassLiterals.``has-background-primary-invert``

    static member inline hasBackgroundLinkInvert =
        PropertyBuilders.mkClass ClassLiterals.``has-background-link-invert``

    static member inline hasBackgroundInfoInvert =
        PropertyBuilders.mkClass ClassLiterals.``has-background-info-invert``

    static member inline hasBackgroundSuccessInvert =
        PropertyBuilders.mkClass ClassLiterals.``has-background-success-invert``

    static member inline hasBackgroundWarningInvert =
        PropertyBuilders.mkClass ClassLiterals.``has-background-warning-invert``

    static member inline hasBackgroundDangerInvert =
        PropertyBuilders.mkClass ClassLiterals.``has-background-danger-invert``

    static member inline hasBackgroundTextLight =
        PropertyBuilders.mkClass ClassLiterals.``has-background-text-light``

    static member inline hasBackgroundPrimaryLight =
        PropertyBuilders.mkClass ClassLiterals.``has-background-primary-light``

    static member inline hasBackgroundLinkLight =
        PropertyBuilders.mkClass ClassLiterals.``has-background-link-light``

    static member inline hasBackgroundInfoLight =
        PropertyBuilders.mkClass ClassLiterals.``has-background-info-light``

    static member inline hasBackgroundSuccessLight =
        PropertyBuilders.mkClass ClassLiterals.``has-background-success-light``

    static member inline hasBackgroundWarningLight =
        PropertyBuilders.mkClass ClassLiterals.``has-background-warning-light``

    static member inline hasBackgroundDangerLight =
        PropertyBuilders.mkClass ClassLiterals.``has-background-danger-light``

    static member inline hasBackgroundTextLightInvert =
        PropertyBuilders.mkClass ClassLiterals.``has-background-text-light-invert``

    static member inline hasBackgroundPrimaryLightInvert =
        PropertyBuilders.mkClass ClassLiterals.``has-background-primary-light-invert``

    static member inline hasBackgroundLinkLightInvert =
        PropertyBuilders.mkClass ClassLiterals.``has-background-link-light-invert``

    static member inline hasBackgroundInfoLightInvert =
        PropertyBuilders.mkClass ClassLiterals.``has-background-info-light-invert``

    static member inline hasBackgroundSuccessLightInvert =
        PropertyBuilders.mkClass ClassLiterals.``has-background-success-light-invert``

    static member inline hasBackgroundWarningLightInvert =
        PropertyBuilders.mkClass ClassLiterals.``has-background-warning-light-invert``

    static member inline hasBackgroundDangerLightInvert =
        PropertyBuilders.mkClass ClassLiterals.``has-background-danger-light-invert``

    static member inline hasBackgroundTextDark =
        PropertyBuilders.mkClass ClassLiterals.``has-background-text-dark``

    static member inline hasBackgroundPrimaryDark =
        PropertyBuilders.mkClass ClassLiterals.``has-background-primary-dark``

    static member inline hasBackgroundLinkDark =
        PropertyBuilders.mkClass ClassLiterals.``has-background-link-dark``

    static member inline hasBackgroundInfoDark =
        PropertyBuilders.mkClass ClassLiterals.``has-background-info-dark``

    static member inline hasBackgroundSuccessDark =
        PropertyBuilders.mkClass ClassLiterals.``has-background-success-dark``

    static member inline hasBackgroundWarningDark =
        PropertyBuilders.mkClass ClassLiterals.``has-background-warning-dark``

    static member inline hasBackgroundDangerDark =
        PropertyBuilders.mkClass ClassLiterals.``has-background-danger-dark``

    static member inline hasBackgroundTextDarkInvert =
        PropertyBuilders.mkClass ClassLiterals.``has-background-text-dark-invert``

    static member inline hasBackgroundPrimaryDarkInvert =
        PropertyBuilders.mkClass ClassLiterals.``has-background-primary-dark-invert``

    static member inline hasBackgroundLinkDarkInvert =
        PropertyBuilders.mkClass ClassLiterals.``has-background-link-dark-invert``

    static member inline hasBackgroundInfoDarkInvert =
        PropertyBuilders.mkClass ClassLiterals.``has-background-info-dark-invert``

    static member inline hasBackgroundSuccessDarkInvert =
        PropertyBuilders.mkClass ClassLiterals.``has-background-success-dark-invert``

    static member inline hasBackgroundWarningDarkInvert =
        PropertyBuilders.mkClass ClassLiterals.``has-background-warning-dark-invert``

    static member inline hasBackgroundDangerDarkInvert =
        PropertyBuilders.mkClass ClassLiterals.``has-background-danger-dark-invert``

    static member inline hasBackgroundTextSoft =
        PropertyBuilders.mkClass ClassLiterals.``has-background-text-soft``

    static member inline hasBackgroundPrimarySoft =
        PropertyBuilders.mkClass ClassLiterals.``has-background-primary-soft``

    static member inline hasBackgroundLinkSoft =
        PropertyBuilders.mkClass ClassLiterals.``has-background-link-soft``

    static member inline hasBackgroundInfoSoft =
        PropertyBuilders.mkClass ClassLiterals.``has-background-info-soft``

    static member inline hasBackgroundSuccessSoft =
        PropertyBuilders.mkClass ClassLiterals.``has-background-success-soft``

    static member inline hasBackgroundWarningSoft =
        PropertyBuilders.mkClass ClassLiterals.``has-background-warning-soft``

    static member inline hasBackgroundDangerSoft =
        PropertyBuilders.mkClass ClassLiterals.``has-background-danger-soft``

    static member inline hasBackgroundTextBold =
        PropertyBuilders.mkClass ClassLiterals.``has-background-text-bold``

    static member inline hasBackgroundPrimaryBold =
        PropertyBuilders.mkClass ClassLiterals.``has-background-primary-bold``

    static member inline hasBackgroundLinkBold =
        PropertyBuilders.mkClass ClassLiterals.``has-background-link-bold``

    static member inline hasBackgroundInfoBold =
        PropertyBuilders.mkClass ClassLiterals.``has-background-info-bold``

    static member inline hasBackgroundSuccessBold =
        PropertyBuilders.mkClass ClassLiterals.``has-background-success-bold``

    static member inline hasBackgroundWarningBold =
        PropertyBuilders.mkClass ClassLiterals.``has-background-warning-bold``

    static member inline hasBackgroundDangerBold =
        PropertyBuilders.mkClass ClassLiterals.``has-background-danger-bold``

    static member inline hasBackgroundTextOnScheme =
        PropertyBuilders.mkClass ClassLiterals.``has-background-text-on-scheme``

    static member inline hasBackgroundPrimaryOnScheme =
        PropertyBuilders.mkClass ClassLiterals.``has-background-primary-on-scheme``

    static member inline hasBackgroundLinkOnScheme =
        PropertyBuilders.mkClass ClassLiterals.``has-background-link-on-scheme``

    static member inline hasBackgroundInfoOnScheme =
        PropertyBuilders.mkClass ClassLiterals.``has-background-info-on-scheme``

    static member inline hasBackgroundSuccessOnScheme =
        PropertyBuilders.mkClass ClassLiterals.``has-background-success-on-scheme``

    static member inline hasBackgroundWarningOnScheme =
        PropertyBuilders.mkClass ClassLiterals.``has-background-warning-on-scheme``

    static member inline hasBackgroundDangerOnScheme =
        PropertyBuilders.mkClass ClassLiterals.``has-background-danger-on-scheme``

    static member inline hasBackgroundText00 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-text-00``

    static member inline hasBackgroundPrimary00 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-primary-00``

    static member inline hasBackgroundLink00 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-link-00``

    static member inline hasBackgroundInfo00 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-info-00``

    static member inline hasBackgroundSuccess00 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-success-00``

    static member inline hasBackgroundWarning00 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-warning-00``

    static member inline hasBackgroundDanger00 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-danger-00``

    static member inline hasBackgroundText05 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-text-05``

    static member inline hasBackgroundPrimary05 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-primary-05``

    static member inline hasBackgroundLink05 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-link-05``

    static member inline hasBackgroundInfo05 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-info-05``

    static member inline hasBackgroundSuccess05 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-success-05``

    static member inline hasBackgroundWarning05 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-warning-05``

    static member inline hasBackgroundDanger05 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-danger-05``

    static member inline hasBackgroundText10 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-text-10``

    static member inline hasBackgroundPrimary10 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-primary-10``

    static member inline hasBackgroundLink10 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-link-10``

    static member inline hasBackgroundInfo10 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-info-10``

    static member inline hasBackgroundSuccess10 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-success-10``

    static member inline hasBackgroundWarning10 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-warning-10``

    static member inline hasBackgroundDanger10 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-danger-10``

    static member inline hasBackgroundText15 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-text-15``

    static member inline hasBackgroundPrimary15 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-primary-15``

    static member inline hasBackgroundLink15 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-link-15``

    static member inline hasBackgroundInfo15 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-info-15``

    static member inline hasBackgroundSuccess15 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-success-15``

    static member inline hasBackgroundWarning15 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-warning-15``

    static member inline hasBackgroundDanger15 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-danger-15``

    static member inline hasBackgroundText20 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-text-20``

    static member inline hasBackgroundPrimary20 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-primary-20``

    static member inline hasBackgroundLink20 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-link-20``

    static member inline hasBackgroundInfo20 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-info-20``

    static member inline hasBackgroundSuccess20 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-success-20``

    static member inline hasBackgroundWarning20 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-warning-20``

    static member inline hasBackgroundDanger20 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-danger-20``

    static member inline hasBackgroundText25 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-text-25``

    static member inline hasBackgroundPrimary25 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-primary-25``

    static member inline hasBackgroundLink25 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-link-25``

    static member inline hasBackgroundInfo25 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-info-25``

    static member inline hasBackgroundSuccess25 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-success-25``

    static member inline hasBackgroundWarning25 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-warning-25``

    static member inline hasBackgroundDanger25 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-danger-25``

    static member inline hasBackgroundText30 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-text-30``

    static member inline hasBackgroundPrimary30 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-primary-30``

    static member inline hasBackgroundLink30 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-link-30``

    static member inline hasBackgroundInfo30 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-info-30``

    static member inline hasBackgroundSuccess30 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-success-30``

    static member inline hasBackgroundWarning30 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-warning-30``

    static member inline hasBackgroundDanger30 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-danger-30``

    static member inline hasBackgroundText35 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-text-35``

    static member inline hasBackgroundPrimary35 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-primary-35``

    static member inline hasBackgroundLink35 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-link-35``

    static member inline hasBackgroundInfo35 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-info-35``

    static member inline hasBackgroundSuccess35 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-success-35``

    static member inline hasBackgroundWarning35 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-warning-35``

    static member inline hasBackgroundDanger35 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-danger-35``

    static member inline hasBackgroundText40 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-text-40``

    static member inline hasBackgroundPrimary40 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-primary-40``

    static member inline hasBackgroundLink40 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-link-40``

    static member inline hasBackgroundInfo40 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-info-40``

    static member inline hasBackgroundSuccess40 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-success-40``

    static member inline hasBackgroundWarning40 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-warning-40``

    static member inline hasBackgroundDanger40 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-danger-40``

    static member inline hasBackgroundText45 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-text-45``

    static member inline hasBackgroundPrimary45 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-primary-45``

    static member inline hasBackgroundLink45 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-link-45``

    static member inline hasBackgroundInfo45 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-info-45``

    static member inline hasBackgroundSuccess45 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-success-45``

    static member inline hasBackgroundWarning45 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-warning-45``

    static member inline hasBackgroundDanger45 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-danger-45``

    static member inline hasBackgroundText50 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-text-50``

    static member inline hasBackgroundPrimary50 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-primary-50``

    static member inline hasBackgroundLink50 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-link-50``

    static member inline hasBackgroundInfo50 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-info-50``

    static member inline hasBackgroundSuccess50 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-success-50``

    static member inline hasBackgroundWarning50 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-warning-50``

    static member inline hasBackgroundDanger50 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-danger-50``

    static member inline hasBackgroundText55 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-text-55``

    static member inline hasBackgroundPrimary55 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-primary-55``

    static member inline hasBackgroundLink55 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-link-55``

    static member inline hasBackgroundInfo55 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-info-55``

    static member inline hasBackgroundSuccess55 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-success-55``

    static member inline hasBackgroundWarning55 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-warning-55``

    static member inline hasBackgroundDanger55 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-danger-55``

    static member inline hasBackgroundText60 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-text-60``

    static member inline hasBackgroundPrimary60 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-primary-60``

    static member inline hasBackgroundLink60 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-link-60``

    static member inline hasBackgroundInfo60 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-info-60``

    static member inline hasBackgroundSuccess60 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-success-60``

    static member inline hasBackgroundWarning60 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-warning-60``

    static member inline hasBackgroundDanger60 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-danger-60``

    static member inline hasBackgroundText65 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-text-65``

    static member inline hasBackgroundPrimary65 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-primary-65``

    static member inline hasBackgroundLink65 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-link-65``

    static member inline hasBackgroundInfo65 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-info-65``

    static member inline hasBackgroundSuccess65 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-success-65``

    static member inline hasBackgroundWarning65 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-warning-65``

    static member inline hasBackgroundDanger65 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-danger-65``

    static member inline hasBackgroundText70 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-text-70``

    static member inline hasBackgroundPrimary70 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-primary-70``

    static member inline hasBackgroundLink70 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-link-70``

    static member inline hasBackgroundInfo70 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-info-70``

    static member inline hasBackgroundSuccess70 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-success-70``

    static member inline hasBackgroundWarning70 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-warning-70``

    static member inline hasBackgroundDanger70 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-danger-70``

    static member inline hasBackgroundText75 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-text-75``

    static member inline hasBackgroundPrimary75 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-primary-75``

    static member inline hasBackgroundLink75 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-link-75``

    static member inline hasBackgroundInfo75 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-info-75``

    static member inline hasBackgroundSuccess75 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-success-75``

    static member inline hasBackgroundWarning75 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-warning-75``

    static member inline hasBackgroundDanger75 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-danger-75``

    static member inline hasBackgroundText80 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-text-80``

    static member inline hasBackgroundPrimary80 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-primary-80``

    static member inline hasBackgroundLink80 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-link-80``

    static member inline hasBackgroundInfo80 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-info-80``

    static member inline hasBackgroundSuccess80 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-success-80``

    static member inline hasBackgroundWarning80 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-warning-80``

    static member inline hasBackgroundDanger80 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-danger-80``

    static member inline hasBackgroundText85 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-text-85``

    static member inline hasBackgroundPrimary85 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-primary-85``

    static member inline hasBackgroundLink85 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-link-85``

    static member inline hasBackgroundInfo85 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-info-85``

    static member inline hasBackgroundSuccess85 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-success-85``

    static member inline hasBackgroundWarning85 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-warning-85``

    static member inline hasBackgroundDanger85 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-danger-85``

    static member inline hasBackgroundText90 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-text-90``

    static member inline hasBackgroundPrimary90 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-primary-90``

    static member inline hasBackgroundLink90 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-link-90``

    static member inline hasBackgroundInfo90 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-info-90``

    static member inline hasBackgroundSuccess90 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-success-90``

    static member inline hasBackgroundWarning90 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-warning-90``

    static member inline hasBackgroundDanger90 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-danger-90``

    static member inline hasBackgroundText95 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-text-95``

    static member inline hasBackgroundPrimary95 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-primary-95``

    static member inline hasBackgroundLink95 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-link-95``

    static member inline hasBackgroundInfo95 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-info-95``

    static member inline hasBackgroundSuccess95 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-success-95``

    static member inline hasBackgroundWarning95 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-warning-95``

    static member inline hasBackgroundDanger95 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-danger-95``

    static member inline hasBackgroundText100 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-text-100``

    static member inline hasBackgroundPrimary100 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-primary-100``

    static member inline hasBackgroundLink100 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-link-100``

    static member inline hasBackgroundInfo100 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-info-100``

    static member inline hasBackgroundSuccess100 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-success-100``

    static member inline hasBackgroundWarning100 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-warning-100``

    static member inline hasBackgroundDanger100 =
        PropertyBuilders.mkClass ClassLiterals.``has-background-danger-100``

    static member inline hasBackgroundCurrent =
        PropertyBuilders.mkClass ClassLiterals.``has-background-current``

    static member inline hasBackgroundInherit =
        PropertyBuilders.mkClass ClassLiterals.``has-background-inherit``

[<Fable.Core.Erase>]
type image =
    static member inline is16x16 = PropertyBuilders.mkClass ClassLiterals.``is-16x16``
    static member inline is24x24 = PropertyBuilders.mkClass ClassLiterals.``is-24x24``
    static member inline is32x32 = PropertyBuilders.mkClass ClassLiterals.``is-32x32``
    static member inline is48x48 = PropertyBuilders.mkClass ClassLiterals.``is-48x48``
    static member inline is64x64 = PropertyBuilders.mkClass ClassLiterals.``is-64x64``
    static member inline is96x96 = PropertyBuilders.mkClass ClassLiterals.``is-96x96``
    static member inline is128x128 = PropertyBuilders.mkClass ClassLiterals.``is-128x128``
    static member inline isRounded = PropertyBuilders.mkClass ClassLiterals.``is-rounded``
    static member inline isSquare = PropertyBuilders.mkClass ClassLiterals.``is-square``
    static member inline is1by1 = PropertyBuilders.mkClass ClassLiterals.``is-1by1``
    static member inline is5by4 = PropertyBuilders.mkClass ClassLiterals.``is-5by4``
    static member inline is4by3 = PropertyBuilders.mkClass ClassLiterals.``is-4by3``
    static member inline is3by2 = PropertyBuilders.mkClass ClassLiterals.``is-3by2``
    static member inline is5by3 = PropertyBuilders.mkClass ClassLiterals.``is-5by3``
    static member inline is16by9 = PropertyBuilders.mkClass ClassLiterals.``is-16by9``
    static member inline is2by1 = PropertyBuilders.mkClass ClassLiterals.``is-2by1``
    static member inline is3by1 = PropertyBuilders.mkClass ClassLiterals.``is-3by1``
    static member inline is4by5 = PropertyBuilders.mkClass ClassLiterals.``is-4by5``
    static member inline is3by4 = PropertyBuilders.mkClass ClassLiterals.``is-3by4``
    static member inline is2by3 = PropertyBuilders.mkClass ClassLiterals.``is-2by3``
    static member inline is3by5 = PropertyBuilders.mkClass ClassLiterals.``is-3by5``
    static member inline is9by16 = PropertyBuilders.mkClass ClassLiterals.``is-9by16``
    static member inline is1by2 = PropertyBuilders.mkClass ClassLiterals.``is-1by2``
    static member inline is1by3 = PropertyBuilders.mkClass ClassLiterals.``is-1by3``
    static member inline isFullWidth = PropertyBuilders.mkClass ClassLiterals.``is-fullwidth``
    static member inline hasRatio = PropertyBuilders.mkClass ClassLiterals.``has-ratio``

[<Fable.Core.Erase>]
type progress =
    static member inline value v = PropertyBuilders.mkValue v
    static member inline max v = PropertyBuilders.mkMax v
    static member inline isSmall = PropertyBuilders.mkClass ClassLiterals.``is-small``
    static member inline isMedium = PropertyBuilders.mkClass ClassLiterals.``is-medium``
    static member inline isLarge = PropertyBuilders.mkClass ClassLiterals.``is-large``

[<Fable.Core.Erase>]
type table =
    static member inline isBordered = PropertyBuilders.mkClass ClassLiterals.``is-bordered``
    static member inline isStriped = PropertyBuilders.mkClass ClassLiterals.``is-striped``
    static member inline isNarrow = PropertyBuilders.mkClass ClassLiterals.``is-narrow``
    static member inline isHoverable = PropertyBuilders.mkClass ClassLiterals.``is-hoverable``
    static member inline isFullWidth = PropertyBuilders.mkClass ClassLiterals.``is-fullwidth``

[<Fable.Core.Erase>]
type tr =
    static member inline isSelected = PropertyBuilders.mkClass ClassLiterals.``is-selected``

[<Fable.Core.Erase>]
type tag =
    static member inline isNormal = PropertyBuilders.mkClass ClassLiterals.``is-normal``
    static member inline isMedium = PropertyBuilders.mkClass ClassLiterals.``is-medium``
    static member inline isLarge = PropertyBuilders.mkClass ClassLiterals.``is-large``
    static member inline isRounded = PropertyBuilders.mkClass ClassLiterals.``is-rounded``
    static member inline isDelete = PropertyBuilders.mkClass ClassLiterals.``is-delete``

[<Fable.Core.Erase>]
type tags =
    static member inline areSmall = PropertyBuilders.mkClass ClassLiterals.``are-small``
    static member inline areMedium = PropertyBuilders.mkClass ClassLiterals.``are-medium``
    static member inline areLarge = PropertyBuilders.mkClass ClassLiterals.``are-large``
    static member inline hasAddons = PropertyBuilders.mkClass ClassLiterals.``has-addons``

[<Fable.Core.Erase>]
type title =
    static member inline isSpaced = PropertyBuilders.mkClass ClassLiterals.``is-spaced``
    static member inline is1 = PropertyBuilders.mkClass ClassLiterals.``is-1``
    static member inline is2 = PropertyBuilders.mkClass ClassLiterals.``is-2``
    static member inline is3 = PropertyBuilders.mkClass ClassLiterals.``is-3``
    static member inline is4 = PropertyBuilders.mkClass ClassLiterals.``is-4``
    static member inline is5 = PropertyBuilders.mkClass ClassLiterals.``is-5``
    static member inline is6 = PropertyBuilders.mkClass ClassLiterals.``is-6``

[<Fable.Core.Erase>]
type tabs =
    static member inline isCentered = PropertyBuilders.mkClass ClassLiterals.``is-centered``
    static member inline isRight = PropertyBuilders.mkClass ClassLiterals.``is-right``
    static member inline isSmall = PropertyBuilders.mkClass ClassLiterals.``is-small``
    static member inline isMedium = PropertyBuilders.mkClass ClassLiterals.``is-medium``
    static member inline isLarge = PropertyBuilders.mkClass ClassLiterals.``is-large``
    static member inline isBoxed = PropertyBuilders.mkClass ClassLiterals.``is-boxed``
    static member inline isToggle = PropertyBuilders.mkClass ClassLiterals.``is-toggle``

    static member inline isToggleRounded =
        PropertyBuilders.mkClass ClassLiterals.``is-toggle-rounded``

    static member inline isFullWidth = PropertyBuilders.mkClass ClassLiterals.``is-fullwidth``

[<Fable.Core.Erase>]
type tab =
    static member inline isActive = PropertyBuilders.mkClass ClassLiterals.``is-active``

[<Fable.Core.Erase>]
type breadcrumb =
    static member inline isCentered = PropertyBuilders.mkClass ClassLiterals.``is-centered``
    static member inline isRight = PropertyBuilders.mkClass ClassLiterals.``is-right``

    static member inline hasArrowSeparator =
        PropertyBuilders.mkClass ClassLiterals.``has-arrow-separator``

    static member inline hasBulletSeparator =
        PropertyBuilders.mkClass ClassLiterals.``has-bullet-separator``

    static member inline hasDotSeparator =
        PropertyBuilders.mkClass ClassLiterals.``has-dot-separator``

    static member inline hasSucceedsSeparator =
        PropertyBuilders.mkClass ClassLiterals.``has-succeeds-separator``

    static member inline isSmall = PropertyBuilders.mkClass ClassLiterals.``is-small``
    static member inline isMedium = PropertyBuilders.mkClass ClassLiterals.``is-medium``
    static member inline isLarge = PropertyBuilders.mkClass ClassLiterals.``is-large``

[<Fable.Core.Erase>]
type cardHeaderTitle =
    static member inline isCentered = PropertyBuilders.mkClass ClassLiterals.``is-centered``

[<Fable.Core.Erase>]
type dropdown =
    static member inline isHoverable = PropertyBuilders.mkClass ClassLiterals.``is-hoverable``
    static member inline isActive = PropertyBuilders.mkClass ClassLiterals.``is-active``
    static member inline isRight = PropertyBuilders.mkClass ClassLiterals.``is-right``
    static member inline isUp = PropertyBuilders.mkClass ClassLiterals.``is-up``

[<Fable.Core.Erase>]
type dropdownItem =
    static member inline isActive = PropertyBuilders.mkClass ClassLiterals.``is-active``

[<Fable.Core.Erase>]
type modal =
    static member inline isActive = PropertyBuilders.mkClass ClassLiterals.``is-active``

[<Fable.Core.Erase>]
type modalClose =
    static member inline isSmall = PropertyBuilders.mkClass ClassLiterals.``is-small``
    static member inline isNormal = PropertyBuilders.mkClass ClassLiterals.``is-normal``
    static member inline isMedium = PropertyBuilders.mkClass ClassLiterals.``is-medium``
    static member inline isLarge = PropertyBuilders.mkClass ClassLiterals.``is-large``

[<Fable.Core.Erase>]
type navbar =
    static member inline isTransparent = PropertyBuilders.mkClass ClassLiterals.``is-transparent``
    static member inline hasShadow = PropertyBuilders.mkClass ClassLiterals.``has-shadow``
    static member inline isFixedTop = PropertyBuilders.mkClass ClassLiterals.``is-fixed-top``

    static member inline isFixedBottom =
        PropertyBuilders.mkClass ClassLiterals.``is-fixed-bottom``

    static member inline isSpaced = PropertyBuilders.mkClass ClassLiterals.``is-spaced``

[<Fable.Core.Erase>]
type navbarMenu =
    static member inline isActive = PropertyBuilders.mkClass ClassLiterals.``is-active``

    [<Obsolete("This prop is deprecated. Use `navbar.isFixedTop` instead.")>]
    static member inline isFixedTop = PropertyBuilders.mkClass ClassLiterals.``is-fixed-top``

    [<Obsolete("This prop is deprecated. Use `navbar.isFixedBottom` instead.")>]
    static member inline isFixedBottom =
        PropertyBuilders.mkClass ClassLiterals.``is-fixed-bottom``

[<Fable.Core.Erase>]
type navbarBurger =
    static member inline isActive = PropertyBuilders.mkClass ClassLiterals.``is-active``

[<Fable.Core.Erase>]
type navbarDropdown =
    static member inline isRight = PropertyBuilders.mkClass ClassLiterals.``is-right``
    static member inline isBoxed = PropertyBuilders.mkClass ClassLiterals.``is-boxed``

[<Fable.Core.Erase>]
type navbarLink =
    static member inline isArrowless = PropertyBuilders.mkClass ClassLiterals.``is-arrowless``

[<Fable.Core.Erase>]
type navbarItem =
    static member inline isExpanded = PropertyBuilders.mkClass ClassLiterals.``is-expanded``
    static member inline isTab = PropertyBuilders.mkClass ClassLiterals.``is-tab``
    static member inline hasDropdown = PropertyBuilders.mkClass ClassLiterals.``has-dropdown``

    static member inline hasDropdownUp =
        PropertyBuilders.mkClass ClassLiterals.``has-dropdown-up``

    static member inline isHoverable = PropertyBuilders.mkClass ClassLiterals.``is-hoverable``
    static member inline isActive = PropertyBuilders.mkClass ClassLiterals.``is-active``

[<Fable.Core.Erase>]
type pagination =
    static member inline isCentered = PropertyBuilders.mkClass ClassLiterals.``is-centered``
    static member inline isRounded = PropertyBuilders.mkClass ClassLiterals.``is-rounded``
    static member inline isRight = PropertyBuilders.mkClass ClassLiterals.``is-right``
    static member inline isSmall = PropertyBuilders.mkClass ClassLiterals.``is-small``
    static member inline isMedium = PropertyBuilders.mkClass ClassLiterals.``is-medium``
    static member inline isLarge = PropertyBuilders.mkClass ClassLiterals.``is-large``

[<Fable.Core.Erase>]
type paginationLink =
    static member inline isCurrent = PropertyBuilders.mkClass ClassLiterals.``is-current``

[<Fable.Core.Erase>]
type file =
    static member inline hasName = PropertyBuilders.mkClass ClassLiterals.``has-name``
    static member inline isRight = PropertyBuilders.mkClass ClassLiterals.``is-right``
    static member inline isCentered = PropertyBuilders.mkClass ClassLiterals.``is-centered``
    static member inline isFullWidth = PropertyBuilders.mkClass ClassLiterals.``is-fullwidth``
    static member inline isBoxed = PropertyBuilders.mkClass ClassLiterals.``is-boxed``
    static member inline isSmall = PropertyBuilders.mkClass ClassLiterals.``is-small``
    static member inline isNormal = PropertyBuilders.mkClass ClassLiterals.``is-normal``
    static member inline isMedium = PropertyBuilders.mkClass ClassLiterals.``is-medium``
    static member inline isLarge = PropertyBuilders.mkClass ClassLiterals.``is-large``

[<Fable.Core.Erase>]
type input =
    static member inline isStatic = PropertyBuilders.mkClass ClassLiterals.``is-static``
    static member inline isSmall = PropertyBuilders.mkClass ClassLiterals.``is-small``
    static member inline isMedium = PropertyBuilders.mkClass ClassLiterals.``is-medium``
    static member inline isLarge = PropertyBuilders.mkClass ClassLiterals.``is-large``
    static member inline isRounded = PropertyBuilders.mkClass ClassLiterals.``is-rounded``
    static member inline isHovered = PropertyBuilders.mkClass ClassLiterals.``is-hovered``
    static member inline isFocused = PropertyBuilders.mkClass ClassLiterals.``is-focused``

[<Fable.Core.Erase>]
type button =
    static member inline isStatic = PropertyBuilders.mkClass ClassLiterals.``is-static``
    static member inline isOutlined = PropertyBuilders.mkClass ClassLiterals.``is-outlined``
    static member inline isLoading = PropertyBuilders.mkClass ClassLiterals.``is-loading``
    static member inline isRounded = PropertyBuilders.mkClass ClassLiterals.``is-rounded``
    static member inline isSmall = PropertyBuilders.mkClass ClassLiterals.``is-small``
    static member inline isNormal = PropertyBuilders.mkClass ClassLiterals.``is-normal``
    static member inline isMedium = PropertyBuilders.mkClass ClassLiterals.``is-medium``
    static member inline isLarge = PropertyBuilders.mkClass ClassLiterals.``is-large``
    static member inline isFullWidth = PropertyBuilders.mkClass ClassLiterals.``is-fullwidth``
    static member inline isInverted = PropertyBuilders.mkClass ClassLiterals.``is-inverted``
    static member inline isHovered = PropertyBuilders.mkClass ClassLiterals.``is-hovered``
    static member inline isFocused = PropertyBuilders.mkClass ClassLiterals.``is-focused``
    static member inline isActive = PropertyBuilders.mkClass ClassLiterals.``is-active``
    static member inline isSelected = PropertyBuilders.mkClass ClassLiterals.``is-selected``
    static member inline isText = PropertyBuilders.mkClass ClassLiterals.``is-text``

[<Fable.Core.Erase>]
type buttons =
    static member inline areSmall = PropertyBuilders.mkClass ClassLiterals.``are-small``
    static member inline areMedium = PropertyBuilders.mkClass ClassLiterals.``are-medium``
    static member inline areLarge = PropertyBuilders.mkClass ClassLiterals.``are-large``
    static member inline hasAddons = PropertyBuilders.mkClass ClassLiterals.``has-addons``
    static member inline isCentered = PropertyBuilders.mkClass ClassLiterals.``is-centered``
    static member inline isRight = PropertyBuilders.mkClass ClassLiterals.``is-right``

[<Fable.Core.Erase>]
type fieldLabel =
    static member inline isSmall = PropertyBuilders.mkClass ClassLiterals.``is-small``
    static member inline isNormal = PropertyBuilders.mkClass ClassLiterals.``is-normal``
    static member inline isMedium = PropertyBuilders.mkClass ClassLiterals.``is-medium``
    static member inline isLarge = PropertyBuilders.mkClass ClassLiterals.``is-large``

[<Fable.Core.Erase>]
type textarea =
    static member inline isSmall = PropertyBuilders.mkClass ClassLiterals.``is-small``
    static member inline isNormal = PropertyBuilders.mkClass ClassLiterals.``is-normal``
    static member inline isMedium = PropertyBuilders.mkClass ClassLiterals.``is-medium``
    static member inline isLarge = PropertyBuilders.mkClass ClassLiterals.``is-large``
    static member inline isHovered = PropertyBuilders.mkClass ClassLiterals.``is-hovered``
    static member inline isFocused = PropertyBuilders.mkClass ClassLiterals.``is-focused``
    static member inline hasFixedSize = PropertyBuilders.mkClass ClassLiterals.``has-fixed-size``

[<Fable.Core.Erase>]
type field =
    static member inline hasAddons = PropertyBuilders.mkClass ClassLiterals.``has-addons``

    static member inline hasAddonsRight =
        PropertyBuilders.mkClass ClassLiterals.``has-addons-right``

    static member inline hasAddonsCentered =
        PropertyBuilders.mkClass ClassLiterals.``has-addons-centered``

    static member inline isGrouped = PropertyBuilders.mkClass ClassLiterals.``is-grouped``

    static member inline isGroupedRight =
        PropertyBuilders.mkClass ClassLiterals.``is-grouped-right``

    static member inline isGroupedCentered =
        PropertyBuilders.mkClass ClassLiterals.``is-grouped-centered``

    static member inline isGroupedMultiline =
        PropertyBuilders.mkClass ClassLiterals.``is-grouped-multiline``

    static member inline isHorizontal = PropertyBuilders.mkClass ClassLiterals.``is-horizontal``
    static member inline isNarrow = PropertyBuilders.mkClass ClassLiterals.``is-narrow``

[<Fable.Core.Erase>]
type icon =
    static member inline isLeft = PropertyBuilders.mkClass ClassLiterals.``is-left``
    static member inline isRight = PropertyBuilders.mkClass ClassLiterals.``is-right``
    static member inline isSmall = PropertyBuilders.mkClass ClassLiterals.``is-small``
    static member inline isMedium = PropertyBuilders.mkClass ClassLiterals.``is-medium``
    static member inline isLarge = PropertyBuilders.mkClass ClassLiterals.``is-large``

[<Fable.Core.Erase>]
type select =
    static member inline isFullWidth = PropertyBuilders.mkClass ClassLiterals.``is-fullwidth``
    static member inline isMultiple = PropertyBuilders.mkClass ClassLiterals.``is-multiple``
    static member inline isRounded = PropertyBuilders.mkClass ClassLiterals.``is-rounded``
    static member inline isSmall = PropertyBuilders.mkClass ClassLiterals.``is-small``
    static member inline isNormal = PropertyBuilders.mkClass ClassLiterals.``is-normal``
    static member inline isMedium = PropertyBuilders.mkClass ClassLiterals.``is-medium``
    static member inline isLarge = PropertyBuilders.mkClass ClassLiterals.``is-large``
    static member inline isHovered = PropertyBuilders.mkClass ClassLiterals.``is-hovered``
    static member inline isFocused = PropertyBuilders.mkClass ClassLiterals.``is-focused``
    static member inline isActive = PropertyBuilders.mkClass ClassLiterals.``is-active``

[<Fable.Core.Erase>]
type control =
    static member inline hasIconsLeft = PropertyBuilders.mkClass ClassLiterals.``has-icons-left``

    static member inline hasIconsRight =
        PropertyBuilders.mkClass ClassLiterals.``has-icons-right``

    static member inline isExpanded = PropertyBuilders.mkClass ClassLiterals.``is-expanded``
    static member inline isLoading = PropertyBuilders.mkClass ClassLiterals.``is-loading``
    static member inline isSmall = PropertyBuilders.mkClass ClassLiterals.``is-small``
    static member inline isMedium = PropertyBuilders.mkClass ClassLiterals.``is-medium``
    static member inline isLarge = PropertyBuilders.mkClass ClassLiterals.``is-large``

[<Fable.Core.Erase>]
type ol =
    static member inline isLowerAlpha = PropertyBuilders.mkClass ClassLiterals.``is-lower-alpha``
    static member inline isLowerRoman = PropertyBuilders.mkClass ClassLiterals.``is-lower-roman``
    static member inline isUpperAlpha = PropertyBuilders.mkClass ClassLiterals.``is-upper-alpha``
    static member inline isUpperRoman = PropertyBuilders.mkClass ClassLiterals.``is-upper-roman``

[<Fable.Core.Erase>]
type content =
    static member inline isSmall = PropertyBuilders.mkClass ClassLiterals.``is-small``
    static member inline isMedium = PropertyBuilders.mkClass ClassLiterals.``is-medium``
    static member inline isLarge = PropertyBuilders.mkClass ClassLiterals.``is-large``

[<Fable.Core.Erase>]
type delete =
    static member inline isSmall = PropertyBuilders.mkClass ClassLiterals.``is-small``
    static member inline isMedium = PropertyBuilders.mkClass ClassLiterals.``is-medium``
    static member inline isLarge = PropertyBuilders.mkClass ClassLiterals.``is-large``

[<Fable.Core.Erase>]
type container =
    static member inline isFluid = PropertyBuilders.mkClass ClassLiterals.``is-fluid``
    static member inline isWidescreen = PropertyBuilders.mkClass ClassLiterals.``is-widescreen``
    static member inline isFullHd = PropertyBuilders.mkClass ClassLiterals.``is-fullhd``
    static member inline isMaxDesktop = PropertyBuilders.mkClass ClassLiterals.``is-max-desktop``
    static member inline isMaxWidescreen = PropertyBuilders.mkClass ClassLiterals.``is-max-widescreen``

[<Fable.Core.Erase>]
type level =
    static member inline isMobile = PropertyBuilders.mkClass ClassLiterals.``is-mobile``

[<RequireQualifiedAccess>]
type section =
    static member inline isMedium = PropertyBuilders.mkClass ClassLiterals.``is-medium``
    static member inline isLarge = PropertyBuilders.mkClass ClassLiterals.``is-large``
    static member inline isFullHeight = PropertyBuilders.mkClass ClassLiterals.``is-fullheight``

[<Fable.Core.Erase>]
type hero =
    static member inline isBold = PropertyBuilders.mkClass ClassLiterals.``is-bold``
    static member inline isMedium = PropertyBuilders.mkClass ClassLiterals.``is-medium``
    static member inline isLarge = PropertyBuilders.mkClass ClassLiterals.``is-large``
    static member inline isFullHeight = PropertyBuilders.mkClass ClassLiterals.``is-fullheight``

    static member inline isFullHeightWithNavbar =
        PropertyBuilders.mkClass ClassLiterals.``is-fullheight-with-navbar``

[<Fable.Core.Erase>]
type columns =
    static member inline isMobile = PropertyBuilders.mkClass ClassLiterals.``is-mobile``
    static member inline isDesktop = PropertyBuilders.mkClass ClassLiterals.``is-desktop``
    static member inline isGapless = PropertyBuilders.mkClass ClassLiterals.``is-gapless``
    static member inline isMultiline = PropertyBuilders.mkClass ClassLiterals.``is-multiline``
    static member inline isVariable = PropertyBuilders.mkClass ClassLiterals.``is-variable``
    static member inline isCentered = PropertyBuilders.mkClass ClassLiterals.``is-centered``
    static member inline isVCentered = PropertyBuilders.mkClass ClassLiterals.``is-vcentered``

[<Fable.Core.Erase>]
type column =
    static member inline is1 = PropertyBuilders.mkClass ClassLiterals.``is-1``
    static member inline is1Mobile = PropertyBuilders.mkClass ClassLiterals.``is-1-mobile``
    static member inline is1Tablet = PropertyBuilders.mkClass ClassLiterals.``is-1-tablet``

    static member inline is1TabletOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-1-tablet-only``

    static member inline is1Touch = PropertyBuilders.mkClass ClassLiterals.``is-1-touch``
    static member inline is1Desktop = PropertyBuilders.mkClass ClassLiterals.``is-1-desktop``

    static member inline is1DesktopOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-1-desktop-only``

    static member inline is1Widescreen =
        PropertyBuilders.mkClass ClassLiterals.``is-1-widescreen``

    static member inline is1WidescreenOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-1-widescreen-only``

    static member inline is1FullHd = PropertyBuilders.mkClass ClassLiterals.``is-1-fullhd``
    static member inline is2 = PropertyBuilders.mkClass ClassLiterals.``is-2``
    static member inline is2Mobile = PropertyBuilders.mkClass ClassLiterals.``is-2-mobile``
    static member inline is2Tablet = PropertyBuilders.mkClass ClassLiterals.``is-2-tablet``

    static member inline is2TabletOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-2-tablet-only``

    static member inline is2Touch = PropertyBuilders.mkClass ClassLiterals.``is-2-touch``
    static member inline is2Desktop = PropertyBuilders.mkClass ClassLiterals.``is-2-desktop``

    static member inline is2DesktopOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-2-desktop-only``

    static member inline is2Widescreen =
        PropertyBuilders.mkClass ClassLiterals.``is-2-widescreen``

    static member inline is2WidescreenOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-2-widescreen-only``

    static member inline is2FullHd = PropertyBuilders.mkClass ClassLiterals.``is-2-fullhd``
    static member inline is3 = PropertyBuilders.mkClass ClassLiterals.``is-3``
    static member inline is3Mobile = PropertyBuilders.mkClass ClassLiterals.``is-3-mobile``
    static member inline is3Tablet = PropertyBuilders.mkClass ClassLiterals.``is-3-tablet``

    static member inline is3TabletOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-3-tablet-only``

    static member inline is3Touch = PropertyBuilders.mkClass ClassLiterals.``is-3-touch``
    static member inline is3Desktop = PropertyBuilders.mkClass ClassLiterals.``is-3-desktop``

    static member inline is3DesktopOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-3-desktop-only``

    static member inline is3Widescreen =
        PropertyBuilders.mkClass ClassLiterals.``is-3-widescreen``

    static member inline is3WidescreenOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-3-widescreen-only``

    static member inline is3FullHd = PropertyBuilders.mkClass ClassLiterals.``is-3-fullhd``
    static member inline is4 = PropertyBuilders.mkClass ClassLiterals.``is-4``
    static member inline is4Mobile = PropertyBuilders.mkClass ClassLiterals.``is-4-mobile``
    static member inline is4Tablet = PropertyBuilders.mkClass ClassLiterals.``is-4-tablet``

    static member inline is4TabletOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-4-tablet-only``

    static member inline is4Touch = PropertyBuilders.mkClass ClassLiterals.``is-4-touch``
    static member inline is4Desktop = PropertyBuilders.mkClass ClassLiterals.``is-4-desktop``

    static member inline is4DesktopOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-4-desktop-only``

    static member inline is4Widescreen =
        PropertyBuilders.mkClass ClassLiterals.``is-4-widescreen``

    static member inline is4WidescreenOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-4-widescreen-only``

    static member inline is4FullHd = PropertyBuilders.mkClass ClassLiterals.``is-4-fullhd``
    static member inline is5 = PropertyBuilders.mkClass ClassLiterals.``is-5``
    static member inline is5Mobile = PropertyBuilders.mkClass ClassLiterals.``is-5-mobile``
    static member inline is5Tablet = PropertyBuilders.mkClass ClassLiterals.``is-5-tablet``

    static member inline is5TabletOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-5-tablet-only``

    static member inline is5Touch = PropertyBuilders.mkClass ClassLiterals.``is-5-touch``
    static member inline is5Desktop = PropertyBuilders.mkClass ClassLiterals.``is-5-desktop``

    static member inline is5DesktopOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-5-desktop-only``

    static member inline is5Widescreen =
        PropertyBuilders.mkClass ClassLiterals.``is-5-widescreen``

    static member inline is5WidescreenOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-5-widescreen-only``

    static member inline is5FullHd = PropertyBuilders.mkClass ClassLiterals.``is-5-fullhd``
    static member inline is6 = PropertyBuilders.mkClass ClassLiterals.``is-6``
    static member inline is6Mobile = PropertyBuilders.mkClass ClassLiterals.``is-6-mobile``
    static member inline is6Tablet = PropertyBuilders.mkClass ClassLiterals.``is-6-tablet``

    static member inline is6TabletOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-6-tablet-only``

    static member inline is6Touch = PropertyBuilders.mkClass ClassLiterals.``is-6-touch``
    static member inline is6Desktop = PropertyBuilders.mkClass ClassLiterals.``is-6-desktop``

    static member inline is6DesktopOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-6-desktop-only``

    static member inline is6Widescreen =
        PropertyBuilders.mkClass ClassLiterals.``is-6-widescreen``

    static member inline is6WidescreenOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-6-widescreen-only``

    static member inline is6FullHd = PropertyBuilders.mkClass ClassLiterals.``is-6-fullhd``
    static member inline is7 = PropertyBuilders.mkClass ClassLiterals.``is-7``
    static member inline is7Mobile = PropertyBuilders.mkClass ClassLiterals.``is-7-mobile``
    static member inline is7Tablet = PropertyBuilders.mkClass ClassLiterals.``is-7-tablet``

    static member inline is7TabletOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-7-tablet-only``

    static member inline is7Touch = PropertyBuilders.mkClass ClassLiterals.``is-7-touch``
    static member inline is7Desktop = PropertyBuilders.mkClass ClassLiterals.``is-7-desktop``

    static member inline is7DesktopOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-7-desktop-only``

    static member inline is7Widescreen =
        PropertyBuilders.mkClass ClassLiterals.``is-7-widescreen``

    static member inline is7WidescreenOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-7-widescreen-only``

    static member inline is7FullHd = PropertyBuilders.mkClass ClassLiterals.``is-7-fullhd``
    static member inline is8 = PropertyBuilders.mkClass ClassLiterals.``is-8``
    static member inline is8Mobile = PropertyBuilders.mkClass ClassLiterals.``is-8-mobile``
    static member inline is8Tablet = PropertyBuilders.mkClass ClassLiterals.``is-8-tablet``

    static member inline is8TabletOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-8-tablet-only``

    static member inline is8Touch = PropertyBuilders.mkClass ClassLiterals.``is-8-touch``
    static member inline is8Desktop = PropertyBuilders.mkClass ClassLiterals.``is-8-desktop``

    static member inline is8DesktopOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-8-desktop-only``

    static member inline is8Widescreen =
        PropertyBuilders.mkClass ClassLiterals.``is-8-widescreen``

    static member inline is8WidescreenOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-8-widescreen-only``

    static member inline is8FullHd = PropertyBuilders.mkClass ClassLiterals.``is-8-fullhd``
    static member inline is9 = PropertyBuilders.mkClass ClassLiterals.``is-9``
    static member inline is9Mobile = PropertyBuilders.mkClass ClassLiterals.``is-9-mobile``
    static member inline is9Tablet = PropertyBuilders.mkClass ClassLiterals.``is-9-tablet``

    static member inline is9TabletOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-9-tablet-only``

    static member inline is9Touch = PropertyBuilders.mkClass ClassLiterals.``is-9-touch``
    static member inline is9Desktop = PropertyBuilders.mkClass ClassLiterals.``is-9-desktop``

    static member inline is9DesktopOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-9-desktop-only``

    static member inline is9Widescreen =
        PropertyBuilders.mkClass ClassLiterals.``is-9-widescreen``

    static member inline is9WidescreenOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-9-widescreen-only``

    static member inline is9FullHd = PropertyBuilders.mkClass ClassLiterals.``is-9-fullhd``
    static member inline is10 = PropertyBuilders.mkClass ClassLiterals.``is-10``
    static member inline is10Mobile = PropertyBuilders.mkClass ClassLiterals.``is-10-mobile``
    static member inline is10Tablet = PropertyBuilders.mkClass ClassLiterals.``is-10-tablet``

    static member inline is10TabletOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-10-tablet-only``

    static member inline is10Touch = PropertyBuilders.mkClass ClassLiterals.``is-10-touch``
    static member inline is10Desktop = PropertyBuilders.mkClass ClassLiterals.``is-10-desktop``

    static member inline is10DesktopOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-10-desktop-only``

    static member inline is10Widescreen =
        PropertyBuilders.mkClass ClassLiterals.``is-10-widescreen``

    static member inline is10WidescreenOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-10-widescreen-only``

    static member inline is10FullHd = PropertyBuilders.mkClass ClassLiterals.``is-10-fullhd``
    static member inline is11 = PropertyBuilders.mkClass ClassLiterals.``is-11``
    static member inline is11Mobile = PropertyBuilders.mkClass ClassLiterals.``is-11-mobile``
    static member inline is11Tablet = PropertyBuilders.mkClass ClassLiterals.``is-11-tablet``

    static member inline is11TabletOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-11-tablet-only``

    static member inline is11Touch = PropertyBuilders.mkClass ClassLiterals.``is-11-touch``
    static member inline is11Desktop = PropertyBuilders.mkClass ClassLiterals.``is-11-desktop``

    static member inline is11DesktopOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-11-desktop-only``

    static member inline is11Widescreen =
        PropertyBuilders.mkClass ClassLiterals.``is-11-widescreen``

    static member inline is11WidescreenOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-11-widescreen-only``

    static member inline is11FullHd = PropertyBuilders.mkClass ClassLiterals.``is-11-fullhd``
    static member inline is12 = PropertyBuilders.mkClass ClassLiterals.``is-12``
    static member inline is12Mobile = PropertyBuilders.mkClass ClassLiterals.``is-12-mobile``
    static member inline is12Tablet = PropertyBuilders.mkClass ClassLiterals.``is-12-tablet``

    static member inline is12TabletOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-12-tablet-only``

    static member inline is12Touch = PropertyBuilders.mkClass ClassLiterals.``is-12-touch``
    static member inline is12Desktop = PropertyBuilders.mkClass ClassLiterals.``is-12-desktop``

    static member inline is12DesktopOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-12-desktop-only``

    static member inline is12Widescreen =
        PropertyBuilders.mkClass ClassLiterals.``is-12-widescreen``

    static member inline is12WidescreenOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-12-widescreen-only``

    static member inline is12FullHd = PropertyBuilders.mkClass ClassLiterals.``is-12-fullhd``

    static member inline isThreeQuarters =
        PropertyBuilders.mkClass ClassLiterals.``is-three-quarters``

    static member inline isThreeQuartersMobile =
        PropertyBuilders.mkClass ClassLiterals.``is-three-quarters-mobile``

    static member inline isThreeQuartersTablet =
        PropertyBuilders.mkClass ClassLiterals.``is-three-quarters-tablet``

    static member inline isThreeQuartersTouch =
        PropertyBuilders.mkClass ClassLiterals.``is-three-quarters-touch``

    static member inline isThreeQuartersDesktop =
        PropertyBuilders.mkClass ClassLiterals.``is-three-quarters-desktop``

    static member inline isThreeQuartersWidescreen =
        PropertyBuilders.mkClass ClassLiterals.``is-three-quarters-widescreen``

    static member inline isThreeQuartersFullHd =
        PropertyBuilders.mkClass ClassLiterals.``is-three-quarters-fullhd``

    static member inline isTwoThirds = PropertyBuilders.mkClass ClassLiterals.``is-two-thirds``

    static member inline isTwoThirdsMobile =
        PropertyBuilders.mkClass ClassLiterals.``is-two-thirds-mobile``

    static member inline isTwoThirdsTablet =
        PropertyBuilders.mkClass ClassLiterals.``is-two-thirds-tablet``

    static member inline isTwoThirdsTouch =
        PropertyBuilders.mkClass ClassLiterals.``is-two-thirds-touch``

    static member inline isTwoThirdsDesktop =
        PropertyBuilders.mkClass ClassLiterals.``is-two-thirds-desktop``

    static member inline isTwoThirdsWidescreen =
        PropertyBuilders.mkClass ClassLiterals.``is-two-thirds-widescreen``

    static member inline isTwoThirdsFullHd =
        PropertyBuilders.mkClass ClassLiterals.``is-two-thirds-fullhd``

    static member inline isHalf = PropertyBuilders.mkClass ClassLiterals.``is-half``
    static member inline isHalfMobile = PropertyBuilders.mkClass ClassLiterals.``is-half-mobile``
    static member inline isHalfTablet = PropertyBuilders.mkClass ClassLiterals.``is-half-tablet``
    static member inline isHalfTouch = PropertyBuilders.mkClass ClassLiterals.``is-half-touch``

    static member inline isHalfDesktop =
        PropertyBuilders.mkClass ClassLiterals.``is-half-desktop``

    static member inline isHalfWidescreen =
        PropertyBuilders.mkClass ClassLiterals.``is-half-widescreen``

    static member inline isHalfFullHd = PropertyBuilders.mkClass ClassLiterals.``is-half-fullhd``
    static member inline isOneThird = PropertyBuilders.mkClass ClassLiterals.``is-one-third``

    static member inline isOneThirdMobile =
        PropertyBuilders.mkClass ClassLiterals.``is-one-third-mobile``

    static member inline isOneThirdTablet =
        PropertyBuilders.mkClass ClassLiterals.``is-one-third-tablet``

    static member inline isOneThirdTouch =
        PropertyBuilders.mkClass ClassLiterals.``is-one-third-touch``

    static member inline isOneThirdDesktop =
        PropertyBuilders.mkClass ClassLiterals.``is-one-third-desktop``

    static member inline isOneThirdWidescreen =
        PropertyBuilders.mkClass ClassLiterals.``is-one-third-widescreen``

    static member inline isOneThirdFullHd =
        PropertyBuilders.mkClass ClassLiterals.``is-one-third-fullhd``

    static member inline isOneQuarter = PropertyBuilders.mkClass ClassLiterals.``is-one-quarter``

    static member inline isOneQuarterMobile =
        PropertyBuilders.mkClass ClassLiterals.``is-one-quarter-mobile``

    static member inline isOneQuarterTablet =
        PropertyBuilders.mkClass ClassLiterals.``is-one-quarter-tablet``

    static member inline isOneQuarterTouch =
        PropertyBuilders.mkClass ClassLiterals.``is-one-quarter-touch``

    static member inline isOneQuarterDesktop =
        PropertyBuilders.mkClass ClassLiterals.``is-one-quarter-desktop``

    static member inline isOneQuarterWidescreen =
        PropertyBuilders.mkClass ClassLiterals.``is-one-quarter-widescreen``

    static member inline isOneQuarterFullHd =
        PropertyBuilders.mkClass ClassLiterals.``is-one-quarter-fullhd``

    static member inline isFull = PropertyBuilders.mkClass ClassLiterals.``is-full``
    static member inline isFullMobile = PropertyBuilders.mkClass ClassLiterals.``is-full-mobile``
    static member inline isFullTablet = PropertyBuilders.mkClass ClassLiterals.``is-full-tablet``
    static member inline isFullTouch = PropertyBuilders.mkClass ClassLiterals.``is-full-touch``

    static member inline isFullDesktop =
        PropertyBuilders.mkClass ClassLiterals.``is-full-desktop``

    static member inline isFullWidescreen =
        PropertyBuilders.mkClass ClassLiterals.``is-full-widescreen``

    static member inline isFullFullHd = PropertyBuilders.mkClass ClassLiterals.``is-full-fullhd``
    static member inline isFourFifths = PropertyBuilders.mkClass ClassLiterals.``is-four-fifths``

    static member inline isFourFifthsMobile =
        PropertyBuilders.mkClass ClassLiterals.``is-four-fifths-mobile``

    static member inline isFourFifthsTablet =
        PropertyBuilders.mkClass ClassLiterals.``is-four-fifths-tablet``

    static member inline isFourFifthsTouch =
        PropertyBuilders.mkClass ClassLiterals.``is-four-fifths-touch``

    static member inline isFourFifthsDesktop =
        PropertyBuilders.mkClass ClassLiterals.``is-four-fifths-desktop``

    static member inline isFourFifthsWidescreen =
        PropertyBuilders.mkClass ClassLiterals.``is-four-fifths-widescreen``

    static member inline isFourFifthsFullHd =
        PropertyBuilders.mkClass ClassLiterals.``is-four-fifths-fullhd``

    static member inline isThreeFifths =
        PropertyBuilders.mkClass ClassLiterals.``is-three-fifths``

    static member inline isThreeFifthsMobile =
        PropertyBuilders.mkClass ClassLiterals.``is-three-fifths-mobile``

    static member inline isThreeFifthsTablet =
        PropertyBuilders.mkClass ClassLiterals.``is-three-fifths-tablet``

    static member inline isThreeFifthsTouch =
        PropertyBuilders.mkClass ClassLiterals.``is-three-fifths-touch``

    static member inline isThreeFifthsDesktop =
        PropertyBuilders.mkClass ClassLiterals.``is-three-fifths-desktop``

    static member inline isThreeFifthsWidescreen =
        PropertyBuilders.mkClass ClassLiterals.``is-three-fifths-widescreen``

    static member inline isThreeFifthsFullHd =
        PropertyBuilders.mkClass ClassLiterals.``is-three-fifths-fullhd``

    static member inline isTwoFifths = PropertyBuilders.mkClass ClassLiterals.``is-two-fifths``

    static member inline isTwoFifthsMobile =
        PropertyBuilders.mkClass ClassLiterals.``is-two-fifths-mobile``

    static member inline isTwoFifthsTablet =
        PropertyBuilders.mkClass ClassLiterals.``is-two-fifths-tablet``

    static member inline isTwoFifthsTouch =
        PropertyBuilders.mkClass ClassLiterals.``is-two-fifths-touch``

    static member inline isTwoFifthsDesktop =
        PropertyBuilders.mkClass ClassLiterals.``is-two-fifths-desktop``

    static member inline isTwoFifthsWidescreen =
        PropertyBuilders.mkClass ClassLiterals.``is-two-fifths-widescreen``

    static member inline isTwoFifthsFullHd =
        PropertyBuilders.mkClass ClassLiterals.``is-two-fifths-fullhd``

    static member inline isOneFifth = PropertyBuilders.mkClass ClassLiterals.``is-one-fifth``

    static member inline isOneFifthMobile =
        PropertyBuilders.mkClass ClassLiterals.``is-one-fifth-mobile``

    static member inline isOneFifthTablet =
        PropertyBuilders.mkClass ClassLiterals.``is-one-fifth-tablet``

    static member inline isOneFifthTouch =
        PropertyBuilders.mkClass ClassLiterals.``is-one-fifth-touch``

    static member inline isOneFifthDesktop =
        PropertyBuilders.mkClass ClassLiterals.``is-one-fifth-desktop``

    static member inline isOneFifthWidescreen =
        PropertyBuilders.mkClass ClassLiterals.``is-one-fifth-widescreen``

    static member inline isOneFifthFullHd =
        PropertyBuilders.mkClass ClassLiterals.``is-one-fifth-fullhd``

    static member inline isNarrow = PropertyBuilders.mkClass ClassLiterals.``is-narrow``

    static member inline isNarrowMobile =
        PropertyBuilders.mkClass ClassLiterals.``is-narrow-mobile``

    static member inline isNarrowTablet =
        PropertyBuilders.mkClass ClassLiterals.``is-narrow-tablet``

    static member inline isNarrowTouch =
        PropertyBuilders.mkClass ClassLiterals.``is-narrow-touch``

    static member inline isNarrowDesktop =
        PropertyBuilders.mkClass ClassLiterals.``is-narrow-desktop``

    static member inline isNarrowWidescreen =
        PropertyBuilders.mkClass ClassLiterals.``is-narrow-widescreen``

    static member inline isNarrowFullHd =
        PropertyBuilders.mkClass ClassLiterals.``is-narrow-fullhd``

    static member inline isOffset1 = PropertyBuilders.mkClass ClassLiterals.``is-offset-1``

    static member inline isOffset1Mobile =
        PropertyBuilders.mkClass ClassLiterals.``is-offset-1-mobile``

    static member inline isOffset1Tablet =
        PropertyBuilders.mkClass ClassLiterals.``is-offset-1-tablet``

    static member inline isOffset1Touch =
        PropertyBuilders.mkClass ClassLiterals.``is-offset-1-touch``

    static member inline isOffset1Desktop =
        PropertyBuilders.mkClass ClassLiterals.``is-offset-1-desktop``

    static member inline isOffset1Widescreen =
        PropertyBuilders.mkClass ClassLiterals.``is-offset-1-widescreen``

    static member inline isOffset1FullHd =
        PropertyBuilders.mkClass ClassLiterals.``is-offset-1-fullhd``

    static member inline isOffset2 = PropertyBuilders.mkClass ClassLiterals.``is-offset-2``

    static member inline isOffset2Mobile =
        PropertyBuilders.mkClass ClassLiterals.``is-offset-2-mobile``

    static member inline isOffset2Tablet =
        PropertyBuilders.mkClass ClassLiterals.``is-offset-2-tablet``

    static member inline isOffset2Touch =
        PropertyBuilders.mkClass ClassLiterals.``is-offset-2-touch``

    static member inline isOffset2Desktop =
        PropertyBuilders.mkClass ClassLiterals.``is-offset-2-desktop``

    static member inline isOffset2Widescreen =
        PropertyBuilders.mkClass ClassLiterals.``is-offset-2-widescreen``

    static member inline isOffset2FullHd =
        PropertyBuilders.mkClass ClassLiterals.``is-offset-2-fullhd``

    static member inline isOffset3 = PropertyBuilders.mkClass ClassLiterals.``is-offset-3``

    static member inline isOffset3Mobile =
        PropertyBuilders.mkClass ClassLiterals.``is-offset-3-mobile``

    static member inline isOffset3Tablet =
        PropertyBuilders.mkClass ClassLiterals.``is-offset-3-tablet``

    static member inline isOffset3Touch =
        PropertyBuilders.mkClass ClassLiterals.``is-offset-3-touch``

    static member inline isOffset3Desktop =
        PropertyBuilders.mkClass ClassLiterals.``is-offset-3-desktop``

    static member inline isOffset3Widescreen =
        PropertyBuilders.mkClass ClassLiterals.``is-offset-3-widescreen``

    static member inline isOffset3FullHd =
        PropertyBuilders.mkClass ClassLiterals.``is-offset-3-fullhd``

    static member inline isOffset4 = PropertyBuilders.mkClass ClassLiterals.``is-offset-4``

    static member inline isOffset4Mobile =
        PropertyBuilders.mkClass ClassLiterals.``is-offset-4-mobile``

    static member inline isOffset4Tablet =
        PropertyBuilders.mkClass ClassLiterals.``is-offset-4-tablet``

    static member inline isOffset4Touch =
        PropertyBuilders.mkClass ClassLiterals.``is-offset-4-touch``

    static member inline isOffset4Desktop =
        PropertyBuilders.mkClass ClassLiterals.``is-offset-4-desktop``

    static member inline isOffset4Widescreen =
        PropertyBuilders.mkClass ClassLiterals.``is-offset-4-widescreen``

    static member inline isOffset4FullHd =
        PropertyBuilders.mkClass ClassLiterals.``is-offset-4-fullhd``

    static member inline isOffset5 = PropertyBuilders.mkClass ClassLiterals.``is-offset-5``

    static member inline isOffset5Mobile =
        PropertyBuilders.mkClass ClassLiterals.``is-offset-5-mobile``

    static member inline isOffset5Tablet =
        PropertyBuilders.mkClass ClassLiterals.``is-offset-5-tablet``

    static member inline isOffset5Touch =
        PropertyBuilders.mkClass ClassLiterals.``is-offset-5-touch``

    static member inline isOffset5Desktop =
        PropertyBuilders.mkClass ClassLiterals.``is-offset-5-desktop``

    static member inline isOffset5Widescreen =
        PropertyBuilders.mkClass ClassLiterals.``is-offset-5-widescreen``

    static member inline isOffset5FullHd =
        PropertyBuilders.mkClass ClassLiterals.``is-offset-5-fullhd``

    static member inline isOffset6 = PropertyBuilders.mkClass ClassLiterals.``is-offset-6``

    static member inline isOffset6Mobile =
        PropertyBuilders.mkClass ClassLiterals.``is-offset-6-mobile``

    static member inline isOffset6Tablet =
        PropertyBuilders.mkClass ClassLiterals.``is-offset-6-tablet``

    static member inline isOffset6Touch =
        PropertyBuilders.mkClass ClassLiterals.``is-offset-6-touch``

    static member inline isOffset6Desktop =
        PropertyBuilders.mkClass ClassLiterals.``is-offset-6-desktop``

    static member inline isOffset6Widescreen =
        PropertyBuilders.mkClass ClassLiterals.``is-offset-6-widescreen``

    static member inline isOffset6FullHd =
        PropertyBuilders.mkClass ClassLiterals.``is-offset-6-fullhd``

    static member inline isOffset7 = PropertyBuilders.mkClass ClassLiterals.``is-offset-7``

    static member inline isOffset7Mobile =
        PropertyBuilders.mkClass ClassLiterals.``is-offset-7-mobile``

    static member inline isOffset7Tablet =
        PropertyBuilders.mkClass ClassLiterals.``is-offset-7-tablet``

    static member inline isOffset7Touch =
        PropertyBuilders.mkClass ClassLiterals.``is-offset-7-touch``

    static member inline isOffset7Desktop =
        PropertyBuilders.mkClass ClassLiterals.``is-offset-7-desktop``

    static member inline isOffset7Widescreen =
        PropertyBuilders.mkClass ClassLiterals.``is-offset-7-widescreen``

    static member inline isOffset7FullHd =
        PropertyBuilders.mkClass ClassLiterals.``is-offset-7-fullhd``

    static member inline isOffset8 = PropertyBuilders.mkClass ClassLiterals.``is-offset-8``

    static member inline isOffset8Mobile =
        PropertyBuilders.mkClass ClassLiterals.``is-offset-8-mobile``

    static member inline isOffset8Tablet =
        PropertyBuilders.mkClass ClassLiterals.``is-offset-8-tablet``

    static member inline isOffset8Touch =
        PropertyBuilders.mkClass ClassLiterals.``is-offset-8-touch``

    static member inline isOffset8Desktop =
        PropertyBuilders.mkClass ClassLiterals.``is-offset-8-desktop``

    static member inline isOffset8Widescreen =
        PropertyBuilders.mkClass ClassLiterals.``is-offset-8-widescreen``

    static member inline isOffset8FullHd =
        PropertyBuilders.mkClass ClassLiterals.``is-offset-8-fullhd``

    static member inline isOffset9 = PropertyBuilders.mkClass ClassLiterals.``is-offset-9``

    static member inline isOffset9Mobile =
        PropertyBuilders.mkClass ClassLiterals.``is-offset-9-mobile``

    static member inline isOffset9Tablet =
        PropertyBuilders.mkClass ClassLiterals.``is-offset-9-tablet``

    static member inline isOffset9Touch =
        PropertyBuilders.mkClass ClassLiterals.``is-offset-9-touch``

    static member inline isOffset9Desktop =
        PropertyBuilders.mkClass ClassLiterals.``is-offset-9-desktop``

    static member inline isOffset9Widescreen =
        PropertyBuilders.mkClass ClassLiterals.``is-offset-9-widescreen``

    static member inline isOffset9FullHd =
        PropertyBuilders.mkClass ClassLiterals.``is-offset-9-fullhd``

    static member inline isOffset10 = PropertyBuilders.mkClass ClassLiterals.``is-offset-10``

    static member inline isOffset10Mobile =
        PropertyBuilders.mkClass ClassLiterals.``is-offset-10-mobile``

    static member inline isOffset10Tablet =
        PropertyBuilders.mkClass ClassLiterals.``is-offset-10-tablet``

    static member inline isOffset10Touch =
        PropertyBuilders.mkClass ClassLiterals.``is-offset-10-touch``

    static member inline isOffset10Desktop =
        PropertyBuilders.mkClass ClassLiterals.``is-offset-10-desktop``

    static member inline isOffset10Widescreen =
        PropertyBuilders.mkClass ClassLiterals.``is-offset-10-widescreen``

    static member inline isOffset10FullHd =
        PropertyBuilders.mkClass ClassLiterals.``is-offset-10-fullhd``

    static member inline isOffset11 = PropertyBuilders.mkClass ClassLiterals.``is-offset-11``

    static member inline isOffset11Mobile =
        PropertyBuilders.mkClass ClassLiterals.``is-offset-11-mobile``

    static member inline isOffset11Tablet =
        PropertyBuilders.mkClass ClassLiterals.``is-offset-11-tablet``

    static member inline isOffset11Touch =
        PropertyBuilders.mkClass ClassLiterals.``is-offset-11-touch``

    static member inline isOffset11Desktop =
        PropertyBuilders.mkClass ClassLiterals.``is-offset-11-desktop``

    static member inline isOffset11Widescreen =
        PropertyBuilders.mkClass ClassLiterals.``is-offset-11-widescreen``

    static member inline isOffset11FullHd =
        PropertyBuilders.mkClass ClassLiterals.``is-offset-11-fullhd``

    static member inline isOffset12 = PropertyBuilders.mkClass ClassLiterals.``is-offset-12``

    static member inline isOffset12Mobile =
        PropertyBuilders.mkClass ClassLiterals.``is-offset-12-mobile``

    static member inline isOffset12Tablet =
        PropertyBuilders.mkClass ClassLiterals.``is-offset-12-tablet``

    static member inline isOffset12Touch =
        PropertyBuilders.mkClass ClassLiterals.``is-offset-12-touch``

    static member inline isOffset12Desktop =
        PropertyBuilders.mkClass ClassLiterals.``is-offset-12-desktop``

    static member inline isOffset12Widescreen =
        PropertyBuilders.mkClass ClassLiterals.``is-offset-12-widescreen``

    static member inline isOffset12FullHd =
        PropertyBuilders.mkClass ClassLiterals.``is-offset-12-fullhd``

    static member inline isOffsetThreeQuarters =
        PropertyBuilders.mkClass ClassLiterals.``is-offset-three-quarters``

    static member inline isOffsetThreeQuartersMobile =
        PropertyBuilders.mkClass ClassLiterals.``is-offset-three-quarters-mobile``

    static member inline isOffsetThreeQuartersTablet =
        PropertyBuilders.mkClass ClassLiterals.``is-offset-three-quarters-tablet``

    static member inline isOffsetThreeQuartersTouch =
        PropertyBuilders.mkClass ClassLiterals.``is-offset-three-quarters-touch``

    static member inline isOffsetThreeQuartersDesktop =
        PropertyBuilders.mkClass ClassLiterals.``is-offset-three-quarters-desktop``

    static member inline isOffsetThreeQuartersWidescreen =
        PropertyBuilders.mkClass ClassLiterals.``is-offset-three-quarters-widescreen``

    static member inline isOffsetThreeQuartersFullHd =
        PropertyBuilders.mkClass ClassLiterals.``is-offset-three-quarters-fullhd``

    static member inline isOffsetTwoThirds =
        PropertyBuilders.mkClass ClassLiterals.``is-offset-two-thirds``

    static member inline isOffsetTwoThirdsMobile =
        PropertyBuilders.mkClass ClassLiterals.``is-offset-two-thirds-mobile``

    static member inline isOffsetTwoThirdsTablet =
        PropertyBuilders.mkClass ClassLiterals.``is-offset-two-thirds-tablet``

    static member inline isOffsetTwoThirdsTouch =
        PropertyBuilders.mkClass ClassLiterals.``is-offset-two-thirds-touch``

    static member inline isOffsetTwoThirdsDesktop =
        PropertyBuilders.mkClass ClassLiterals.``is-offset-two-thirds-desktop``

    static member inline isOffsetTwoThirdsWidescreen =
        PropertyBuilders.mkClass ClassLiterals.``is-offset-two-thirds-widescreen``

    static member inline isOffsetTwoThirdsFullHd =
        PropertyBuilders.mkClass ClassLiterals.``is-offset-two-thirds-fullhd``

    static member inline isOffsetHalf = PropertyBuilders.mkClass ClassLiterals.``is-offset-half``

    static member inline isOffsetHalfMobile =
        PropertyBuilders.mkClass ClassLiterals.``is-offset-half-mobile``

    static member inline isOffsetHalfTablet =
        PropertyBuilders.mkClass ClassLiterals.``is-offset-half-tablet``

    static member inline isOffsetHalfTouch =
        PropertyBuilders.mkClass ClassLiterals.``is-offset-half-touch``

    static member inline isOffsetHalfDesktop =
        PropertyBuilders.mkClass ClassLiterals.``is-offset-half-desktop``

    static member inline isOffsetHalfWidescreen =
        PropertyBuilders.mkClass ClassLiterals.``is-offset-half-widescreen``

    static member inline isOffsetHalfFullHd =
        PropertyBuilders.mkClass ClassLiterals.``is-offset-half-fullhd``

    static member inline isOffsetOneThird =
        PropertyBuilders.mkClass ClassLiterals.``is-offset-one-third``

    static member inline isOffsetOneThirdMobile =
        PropertyBuilders.mkClass ClassLiterals.``is-offset-one-third-mobile``

    static member inline isOffsetOneThirdTablet =
        PropertyBuilders.mkClass ClassLiterals.``is-offset-one-third-tablet``

    static member inline isOffsetOneThirdTouch =
        PropertyBuilders.mkClass ClassLiterals.``is-offset-one-third-touch``

    static member inline isOffsetOneThirdDesktop =
        PropertyBuilders.mkClass ClassLiterals.``is-offset-one-third-desktop``

    static member inline isOffsetOneThirdWidescreen =
        PropertyBuilders.mkClass ClassLiterals.``is-offset-one-third-widescreen``

    static member inline isOffsetOneThirdFullHd =
        PropertyBuilders.mkClass ClassLiterals.``is-offset-one-third-fullhd``

    static member inline isOffsetOneQuarter =
        PropertyBuilders.mkClass ClassLiterals.``is-offset-one-quarter``

    static member inline isOffsetOneQuarterMobile =
        PropertyBuilders.mkClass ClassLiterals.``is-offset-one-quarter-mobile``

    static member inline isOffsetOneQuarterTablet =
        PropertyBuilders.mkClass ClassLiterals.``is-offset-one-quarter-tablet``

    static member inline isOffsetOneQuarterTouch =
        PropertyBuilders.mkClass ClassLiterals.``is-offset-one-quarter-touch``

    static member inline isOffsetOneQuarterDesktop =
        PropertyBuilders.mkClass ClassLiterals.``is-offset-one-quarter-desktop``

    static member inline isOffsetOneQuarterWidescreen =
        PropertyBuilders.mkClass ClassLiterals.``is-offset-one-quarter-widescreen``

    static member inline isOffsetOneQuarterFullHd =
        PropertyBuilders.mkClass ClassLiterals.``is-offset-one-quarter-fullhd``

    static member inline isOffsetFull = PropertyBuilders.mkClass ClassLiterals.``is-offset-full``

    static member inline isOffsetFullMobile =
        PropertyBuilders.mkClass ClassLiterals.``is-offset-full-mobile``

    static member inline isOffsetFullTablet =
        PropertyBuilders.mkClass ClassLiterals.``is-offset-full-tablet``

    static member inline isOffsetFullTouch =
        PropertyBuilders.mkClass ClassLiterals.``is-offset-full-touch``

    static member inline isOffsetFullDesktop =
        PropertyBuilders.mkClass ClassLiterals.``is-offset-full-desktop``

    static member inline isOffsetFullWidescreen =
        PropertyBuilders.mkClass ClassLiterals.``is-offset-full-widescreen``

    static member inline isOffsetFullFullHd =
        PropertyBuilders.mkClass ClassLiterals.``is-offset-full-fullhd``

    static member inline isOffsetFourFifths =
        PropertyBuilders.mkClass ClassLiterals.``is-offset-four-fifths``

    static member inline isOffsetFourFifthsMobile =
        PropertyBuilders.mkClass ClassLiterals.``is-offset-four-fifths-mobile``

    static member inline isOffsetFourFifthsTablet =
        PropertyBuilders.mkClass ClassLiterals.``is-offset-four-fifths-tablet``

    static member inline isOffsetFourFifthsTouch =
        PropertyBuilders.mkClass ClassLiterals.``is-offset-four-fifths-touch``

    static member inline isOffsetFourFifthsDesktop =
        PropertyBuilders.mkClass ClassLiterals.``is-offset-four-fifths-desktop``

    static member inline isOffsetFourFifthsWidescreen =
        PropertyBuilders.mkClass ClassLiterals.``is-offset-four-fifths-widescreen``

    static member inline isOffsetFourFifthsFullHd =
        PropertyBuilders.mkClass ClassLiterals.``is-offset-four-fifths-fullhd``

    static member inline isOffsetThreeFifths =
        PropertyBuilders.mkClass ClassLiterals.``is-offset-three-fifths``

    static member inline isOffsetThreeFifthsMobile =
        PropertyBuilders.mkClass ClassLiterals.``is-offset-three-fifths-mobile``

    static member inline isOffsetThreeFifthsTablet =
        PropertyBuilders.mkClass ClassLiterals.``is-offset-three-fifths-tablet``

    static member inline isOffsetThreeFifthsTouch =
        PropertyBuilders.mkClass ClassLiterals.``is-offset-three-fifths-touch``

    static member inline isOffsetThreeFifthsDesktop =
        PropertyBuilders.mkClass ClassLiterals.``is-offset-three-fifths-desktop``

    static member inline isOffsetThreeFifthsWidescreen =
        PropertyBuilders.mkClass ClassLiterals.``is-offset-three-fifths-widescreen``

    static member inline isOffsetThreeFifthsFullHd =
        PropertyBuilders.mkClass ClassLiterals.``is-offset-three-fifths-fullhd``

    static member inline isOffsetTwoFifths =
        PropertyBuilders.mkClass ClassLiterals.``is-offset-two-fifths``

    static member inline isOffsetTwoFifthsMobile =
        PropertyBuilders.mkClass ClassLiterals.``is-offset-two-fifths-mobile``

    static member inline isOffsetTwoFifthsTablet =
        PropertyBuilders.mkClass ClassLiterals.``is-offset-two-fifths-tablet``

    static member inline isOffsetTwoFifthsTouch =
        PropertyBuilders.mkClass ClassLiterals.``is-offset-two-fifths-touch``

    static member inline isOffsetTwoFifthsDesktop =
        PropertyBuilders.mkClass ClassLiterals.``is-offset-two-fifths-desktop``

    static member inline isOffsetTwoFifthsWidescreen =
        PropertyBuilders.mkClass ClassLiterals.``is-offset-two-fifths-widescreen``

    static member inline isOffsetTwoFifthsFullHd =
        PropertyBuilders.mkClass ClassLiterals.``is-offset-two-fifths-fullhd``

    static member inline isOffsetOneFifth =
        PropertyBuilders.mkClass ClassLiterals.``is-offset-one-fifth``

    static member inline isOffsetOneFifthMobile =
        PropertyBuilders.mkClass ClassLiterals.``is-offset-one-fifth-mobile``

    static member inline isOffsetOneFifthTablet =
        PropertyBuilders.mkClass ClassLiterals.``is-offset-one-fifth-tablet``

    static member inline isOffsetOneFifthTouch =
        PropertyBuilders.mkClass ClassLiterals.``is-offset-one-fifth-touch``

    static member inline isOffsetOneFifthDesktop =
        PropertyBuilders.mkClass ClassLiterals.``is-offset-one-fifth-desktop``

    static member inline isOffsetOneFifthWidescreen =
        PropertyBuilders.mkClass ClassLiterals.``is-offset-one-fifth-widescreen``

    static member inline isOffsetOneFifthFullHd =
        PropertyBuilders.mkClass ClassLiterals.``is-offset-one-fifth-fullhd``

[<Fable.Core.Erase>]
type grid =
    static member inline isColMin1 = PropertyBuilders.mkClass ClassLiterals.``is-col-min-1``
    static member inline isColMin2 = PropertyBuilders.mkClass ClassLiterals.``is-col-min-2``
    static member inline isColMin3 = PropertyBuilders.mkClass ClassLiterals.``is-col-min-3``
    static member inline isColMin4 = PropertyBuilders.mkClass ClassLiterals.``is-col-min-4``
    static member inline isColMin5 = PropertyBuilders.mkClass ClassLiterals.``is-col-min-5``
    static member inline isColMin6 = PropertyBuilders.mkClass ClassLiterals.``is-col-min-6``
    static member inline isColMin7 = PropertyBuilders.mkClass ClassLiterals.``is-col-min-7``
    static member inline isColMin8 = PropertyBuilders.mkClass ClassLiterals.``is-col-min-8``
    static member inline isColMin9 = PropertyBuilders.mkClass ClassLiterals.``is-col-min-9``
    static member inline isColMin10 = PropertyBuilders.mkClass ClassLiterals.``is-col-min-10``
    static member inline isColMin11 = PropertyBuilders.mkClass ClassLiterals.``is-col-min-11``
    static member inline isColMin12 = PropertyBuilders.mkClass ClassLiterals.``is-col-min-12``
    static member inline isColMin13 = PropertyBuilders.mkClass ClassLiterals.``is-col-min-13``
    static member inline isColMin14 = PropertyBuilders.mkClass ClassLiterals.``is-col-min-14``
    static member inline isColMin15 = PropertyBuilders.mkClass ClassLiterals.``is-col-min-15``
    static member inline isColMin16 = PropertyBuilders.mkClass ClassLiterals.``is-col-min-16``
    static member inline isColMin17 = PropertyBuilders.mkClass ClassLiterals.``is-col-min-17``
    static member inline isColMin18 = PropertyBuilders.mkClass ClassLiterals.``is-col-min-18``
    static member inline isColMin19 = PropertyBuilders.mkClass ClassLiterals.``is-col-min-19``
    static member inline isColMin20 = PropertyBuilders.mkClass ClassLiterals.``is-col-min-20``
    static member inline isColMin21 = PropertyBuilders.mkClass ClassLiterals.``is-col-min-21``
    static member inline isColMin22 = PropertyBuilders.mkClass ClassLiterals.``is-col-min-22``
    static member inline isColMin23 = PropertyBuilders.mkClass ClassLiterals.``is-col-min-23``
    static member inline isColMin24 = PropertyBuilders.mkClass ClassLiterals.``is-col-min-24``
    static member inline isColMin25 = PropertyBuilders.mkClass ClassLiterals.``is-col-min-25``
    static member inline isColMin26 = PropertyBuilders.mkClass ClassLiterals.``is-col-min-26``
    static member inline isColMin27 = PropertyBuilders.mkClass ClassLiterals.``is-col-min-27``
    static member inline isColMin28 = PropertyBuilders.mkClass ClassLiterals.``is-col-min-28``
    static member inline isColMin29 = PropertyBuilders.mkClass ClassLiterals.``is-col-min-29``
    static member inline isColMin30 = PropertyBuilders.mkClass ClassLiterals.``is-col-min-30``
    static member inline isColMin31 = PropertyBuilders.mkClass ClassLiterals.``is-col-min-31``
    static member inline isColMin32 = PropertyBuilders.mkClass ClassLiterals.``is-col-min-32``

    static member inline isGap0 = PropertyBuilders.mkClass ClassLiterals.``is-gap-0``
    static member inline ``isGap0.5`` = PropertyBuilders.mkClass ClassLiterals.``is-gap-0.5``
    static member inline isGap1 = PropertyBuilders.mkClass ClassLiterals.``is-gap-1``
    static member inline ``isGap1.5`` = PropertyBuilders.mkClass ClassLiterals.``is-gap-1.5``
    static member inline isGap2 = PropertyBuilders.mkClass ClassLiterals.``is-gap-2``
    static member inline ``isGap2.5`` = PropertyBuilders.mkClass ClassLiterals.``is-gap-2.5``
    static member inline isGap3 = PropertyBuilders.mkClass ClassLiterals.``is-gap-3``
    static member inline ``isGap3.5`` = PropertyBuilders.mkClass ClassLiterals.``is-gap-3.5``
    static member inline isGap4 = PropertyBuilders.mkClass ClassLiterals.``is-gap-4``
    static member inline ``isGap4.5`` = PropertyBuilders.mkClass ClassLiterals.``is-gap-4.5``
    static member inline isGap5 = PropertyBuilders.mkClass ClassLiterals.``is-gap-5``
    static member inline ``isGap5.5`` = PropertyBuilders.mkClass ClassLiterals.``is-gap-5.5``
    static member inline isGap6 = PropertyBuilders.mkClass ClassLiterals.``is-gap-6``
    static member inline ``isGap6.5`` = PropertyBuilders.mkClass ClassLiterals.``is-gap-6.5``
    static member inline isGap7 = PropertyBuilders.mkClass ClassLiterals.``is-gap-7``
    static member inline ``isGap7.5`` = PropertyBuilders.mkClass ClassLiterals.``is-gap-7.5``
    static member inline isGap8 = PropertyBuilders.mkClass ClassLiterals.``is-gap-8``

    static member inline isColumnGap0 = PropertyBuilders.mkClass ClassLiterals.``is-column-gap-0``

    static member inline ``isColumnGap0.5`` =
        PropertyBuilders.mkClass ClassLiterals.``is-column-gap-0.5``

    static member inline isColumnGap1 = PropertyBuilders.mkClass ClassLiterals.``is-column-gap-1``

    static member inline ``isColumnGap1.5`` =
        PropertyBuilders.mkClass ClassLiterals.``is-column-gap-1.5``

    static member inline isColumnGap2 = PropertyBuilders.mkClass ClassLiterals.``is-column-gap-2``

    static member inline ``isColumnGap2.5`` =
        PropertyBuilders.mkClass ClassLiterals.``is-column-gap-2.5``

    static member inline isColumnGap3 = PropertyBuilders.mkClass ClassLiterals.``is-column-gap-3``

    static member inline ``isColumnGap3.5`` =
        PropertyBuilders.mkClass ClassLiterals.``is-column-gap-3.5``

    static member inline isColumnGap4 = PropertyBuilders.mkClass ClassLiterals.``is-column-gap-4``

    static member inline ``isColumnGap4.5`` =
        PropertyBuilders.mkClass ClassLiterals.``is-column-gap-4.5``

    static member inline isColumnGap5 = PropertyBuilders.mkClass ClassLiterals.``is-column-gap-5``

    static member inline ``isColumnGap5.5`` =
        PropertyBuilders.mkClass ClassLiterals.``is-column-gap-5.5``

    static member inline isColumnGap6 = PropertyBuilders.mkClass ClassLiterals.``is-column-gap-6``

    static member inline ``isColumnGap6.5`` =
        PropertyBuilders.mkClass ClassLiterals.``is-column-gap-6.5``

    static member inline isColumnGap7 = PropertyBuilders.mkClass ClassLiterals.``is-column-gap-7``

    static member inline ``isColumnGap7.5`` =
        PropertyBuilders.mkClass ClassLiterals.``is-column-gap-7.5``

    static member inline isColumnGap8 = PropertyBuilders.mkClass ClassLiterals.``is-column-gap-8``

    static member inline isRowGap0 = PropertyBuilders.mkClass ClassLiterals.``is-row-gap-0``

    static member inline ``isRowGap0.5`` =
        PropertyBuilders.mkClass ClassLiterals.``is-row-gap-0.5``

    static member inline isRowGap1 = PropertyBuilders.mkClass ClassLiterals.``is-row-gap-1``

    static member inline ``isRowGap1.5`` =
        PropertyBuilders.mkClass ClassLiterals.``is-row-gap-1.5``

    static member inline isRowGap2 = PropertyBuilders.mkClass ClassLiterals.``is-row-gap-2``

    static member inline ``isRowGap2.5`` =
        PropertyBuilders.mkClass ClassLiterals.``is-row-gap-2.5``

    static member inline isRowGap3 = PropertyBuilders.mkClass ClassLiterals.``is-row-gap-3``

    static member inline ``isRowGap3.5`` =
        PropertyBuilders.mkClass ClassLiterals.``is-row-gap-3.5``

    static member inline isRowGap4 = PropertyBuilders.mkClass ClassLiterals.``is-row-gap-4``

    static member inline ``isRowGap4.5`` =
        PropertyBuilders.mkClass ClassLiterals.``is-row-gap-4.5``

    static member inline isRowGap5 = PropertyBuilders.mkClass ClassLiterals.``is-row-gap-5``

    static member inline ``isRowGap5.5`` =
        PropertyBuilders.mkClass ClassLiterals.``is-row-gap-5.5``

    static member inline isRowGap6 = PropertyBuilders.mkClass ClassLiterals.``is-row-gap-6``

    static member inline ``isRowGap6.5`` =
        PropertyBuilders.mkClass ClassLiterals.``is-row-gap-6.5``

    static member inline isRowGap7 = PropertyBuilders.mkClass ClassLiterals.``is-row-gap-7``

    static member inline ``isRowGap7.5`` =
        PropertyBuilders.mkClass ClassLiterals.``is-row-gap-7.5``

    static member inline isRowGap8 = PropertyBuilders.mkClass ClassLiterals.``is-row-gap-8``

[<Fable.Core.Erase>]
type fixedGrid =
    static member inline hasAutoCount = PropertyBuilders.mkClass ClassLiterals.``has-auto-count``

    static member inline has1Cols = PropertyBuilders.mkClass ClassLiterals.``has-1-cols``
    static member inline has2Cols = PropertyBuilders.mkClass ClassLiterals.``has-2-cols``
    static member inline has3Cols = PropertyBuilders.mkClass ClassLiterals.``has-3-cols``
    static member inline has4Cols = PropertyBuilders.mkClass ClassLiterals.``has-4-cols``
    static member inline has5Cols = PropertyBuilders.mkClass ClassLiterals.``has-5-cols``
    static member inline has6Cols = PropertyBuilders.mkClass ClassLiterals.``has-6-cols``
    static member inline has7Cols = PropertyBuilders.mkClass ClassLiterals.``has-7-cols``
    static member inline has8Cols = PropertyBuilders.mkClass ClassLiterals.``has-8-cols``
    static member inline has9Cols = PropertyBuilders.mkClass ClassLiterals.``has-9-cols``
    static member inline has10Cols = PropertyBuilders.mkClass ClassLiterals.``has-10-cols``
    static member inline has11Cols = PropertyBuilders.mkClass ClassLiterals.``has-11-cols``
    static member inline has12Cols = PropertyBuilders.mkClass ClassLiterals.``has-12-cols``

    static member inline has1ColsMobile =
        PropertyBuilders.mkClass ClassLiterals.``has-1-cols-mobile``

    static member inline has2ColsMobile =
        PropertyBuilders.mkClass ClassLiterals.``has-2-cols-mobile``

    static member inline has3ColsMobile =
        PropertyBuilders.mkClass ClassLiterals.``has-3-cols-mobile``

    static member inline has4ColsMobile =
        PropertyBuilders.mkClass ClassLiterals.``has-4-cols-mobile``

    static member inline has5ColsMobile =
        PropertyBuilders.mkClass ClassLiterals.``has-5-cols-mobile``

    static member inline has6ColsMobile =
        PropertyBuilders.mkClass ClassLiterals.``has-6-cols-mobile``

    static member inline has7ColsMobile =
        PropertyBuilders.mkClass ClassLiterals.``has-7-cols-mobile``

    static member inline has8ColsMobile =
        PropertyBuilders.mkClass ClassLiterals.``has-8-cols-mobile``

    static member inline has9ColsMobile =
        PropertyBuilders.mkClass ClassLiterals.``has-9-cols-mobile``

    static member inline has10ColsMobile =
        PropertyBuilders.mkClass ClassLiterals.``has-10-cols-mobile``

    static member inline has11ColsMobile =
        PropertyBuilders.mkClass ClassLiterals.``has-11-cols-mobile``

    static member inline has12ColsMobile =
        PropertyBuilders.mkClass ClassLiterals.``has-12-cols-mobile``

    static member inline has1ColsTablet =
        PropertyBuilders.mkClass ClassLiterals.``has-1-cols-tablet``

    static member inline has2ColsTablet =
        PropertyBuilders.mkClass ClassLiterals.``has-2-cols-tablet``

    static member inline has3ColsTablet =
        PropertyBuilders.mkClass ClassLiterals.``has-3-cols-tablet``

    static member inline has4ColsTablet =
        PropertyBuilders.mkClass ClassLiterals.``has-4-cols-tablet``

    static member inline has5ColsTablet =
        PropertyBuilders.mkClass ClassLiterals.``has-5-cols-tablet``

    static member inline has6ColsTablet =
        PropertyBuilders.mkClass ClassLiterals.``has-6-cols-tablet``

    static member inline has7ColsTablet =
        PropertyBuilders.mkClass ClassLiterals.``has-7-cols-tablet``

    static member inline has8ColsTablet =
        PropertyBuilders.mkClass ClassLiterals.``has-8-cols-tablet``

    static member inline has9ColsTablet =
        PropertyBuilders.mkClass ClassLiterals.``has-9-cols-tablet``

    static member inline has10ColsTablet =
        PropertyBuilders.mkClass ClassLiterals.``has-10-cols-tablet``

    static member inline has11ColsTablet =
        PropertyBuilders.mkClass ClassLiterals.``has-11-cols-tablet``

    static member inline has12ColsTablet =
        PropertyBuilders.mkClass ClassLiterals.``has-12-cols-tablet``

    static member inline has1ColsDesktop =
        PropertyBuilders.mkClass ClassLiterals.``has-1-cols-desktop``

    static member inline has2ColsDesktop =
        PropertyBuilders.mkClass ClassLiterals.``has-2-cols-desktop``

    static member inline has3ColsDesktop =
        PropertyBuilders.mkClass ClassLiterals.``has-3-cols-desktop``

    static member inline has4ColsDesktop =
        PropertyBuilders.mkClass ClassLiterals.``has-4-cols-desktop``

    static member inline has5ColsDesktop =
        PropertyBuilders.mkClass ClassLiterals.``has-5-cols-desktop``

    static member inline has6ColsDesktop =
        PropertyBuilders.mkClass ClassLiterals.``has-6-cols-desktop``

    static member inline has7ColsDesktop =
        PropertyBuilders.mkClass ClassLiterals.``has-7-cols-desktop``

    static member inline has8ColsDesktop =
        PropertyBuilders.mkClass ClassLiterals.``has-8-cols-desktop``

    static member inline has9ColsDesktop =
        PropertyBuilders.mkClass ClassLiterals.``has-9-cols-desktop``

    static member inline has10ColsDesktop =
        PropertyBuilders.mkClass ClassLiterals.``has-10-cols-desktop``

    static member inline has11ColsDesktop =
        PropertyBuilders.mkClass ClassLiterals.``has-11-cols-desktop``

    static member inline has12ColsDesktop =
        PropertyBuilders.mkClass ClassLiterals.``has-12-cols-desktop``

    static member inline has1ColsWideScreen =
        PropertyBuilders.mkClass ClassLiterals.``has-1-cols-widescreen``

    static member inline has2ColsWideScreen =
        PropertyBuilders.mkClass ClassLiterals.``has-2-cols-widescreen``

    static member inline has3ColsWideScreen =
        PropertyBuilders.mkClass ClassLiterals.``has-3-cols-widescreen``

    static member inline has4ColsWideScreen =
        PropertyBuilders.mkClass ClassLiterals.``has-4-cols-widescreen``

    static member inline has5ColsWideScreen =
        PropertyBuilders.mkClass ClassLiterals.``has-5-cols-widescreen``

    static member inline has6ColsWideScreen =
        PropertyBuilders.mkClass ClassLiterals.``has-6-cols-widescreen``

    static member inline has7ColsWideScreen =
        PropertyBuilders.mkClass ClassLiterals.``has-7-cols-widescreen``

    static member inline has8ColsWideScreen =
        PropertyBuilders.mkClass ClassLiterals.``has-8-cols-widescreen``

    static member inline has9ColsWideScreen =
        PropertyBuilders.mkClass ClassLiterals.``has-9-cols-widescreen``

    static member inline has10ColsWideScreen =
        PropertyBuilders.mkClass ClassLiterals.``has-10-cols-widescreen``

    static member inline has11ColsWideScreen =
        PropertyBuilders.mkClass ClassLiterals.``has-11-cols-widescreen``

    static member inline has12ColsWideScreen =
        PropertyBuilders.mkClass ClassLiterals.``has-12-cols-widescreen``

    static member inline has1ColsFullhd =
        PropertyBuilders.mkClass ClassLiterals.``has-1-cols-fullhd``

    static member inline has2ColsFullhd =
        PropertyBuilders.mkClass ClassLiterals.``has-2-cols-fullhd``

    static member inline has3ColsFullhd =
        PropertyBuilders.mkClass ClassLiterals.``has-3-cols-fullhd``

    static member inline has4ColsFullhd =
        PropertyBuilders.mkClass ClassLiterals.``has-4-cols-fullhd``

    static member inline has5ColsFullhd =
        PropertyBuilders.mkClass ClassLiterals.``has-5-cols-fullhd``

    static member inline has6ColsFullhd =
        PropertyBuilders.mkClass ClassLiterals.``has-6-cols-fullhd``

    static member inline has7ColsFullhd =
        PropertyBuilders.mkClass ClassLiterals.``has-7-cols-fullhd``

    static member inline has8ColsFullhd =
        PropertyBuilders.mkClass ClassLiterals.``has-8-cols-fullhd``

    static member inline has9ColsFullhd =
        PropertyBuilders.mkClass ClassLiterals.``has-9-cols-fullhd``

    static member inline has10ColsFullhd =
        PropertyBuilders.mkClass ClassLiterals.``has-10-cols-fullhd``

    static member inline has11ColsFullhd =
        PropertyBuilders.mkClass ClassLiterals.``has-11-cols-fullhd``

    static member inline has12ColsFullhd =
        PropertyBuilders.mkClass ClassLiterals.``has-12-cols-fullhd``

[<Fable.Core.Erase>]
type cell =
    static member inline isColStart1 = PropertyBuilders.mkClass ClassLiterals.``is-col-start-1``
    static member inline isColStart2 = PropertyBuilders.mkClass ClassLiterals.``is-col-start-2``
    static member inline isColStart3 = PropertyBuilders.mkClass ClassLiterals.``is-col-start-3``
    static member inline isColStart4 = PropertyBuilders.mkClass ClassLiterals.``is-col-start-4``
    static member inline isColStart5 = PropertyBuilders.mkClass ClassLiterals.``is-col-start-5``
    static member inline isColStart6 = PropertyBuilders.mkClass ClassLiterals.``is-col-start-6``
    static member inline isColStart7 = PropertyBuilders.mkClass ClassLiterals.``is-col-start-7``
    static member inline isColStart8 = PropertyBuilders.mkClass ClassLiterals.``is-col-start-8``
    static member inline isColStart9 = PropertyBuilders.mkClass ClassLiterals.``is-col-start-9``
    static member inline isColStart10 = PropertyBuilders.mkClass ClassLiterals.``is-col-start-10``
    static member inline isColStart11 = PropertyBuilders.mkClass ClassLiterals.``is-col-start-11``
    static member inline isColStart12 = PropertyBuilders.mkClass ClassLiterals.``is-col-start-12``

    static member inline isColFromEnd1 =
        PropertyBuilders.mkClass ClassLiterals.``is-col-from-end-1``

    static member inline isColFromEnd2 =
        PropertyBuilders.mkClass ClassLiterals.``is-col-from-end-2``

    static member inline isColFromEnd3 =
        PropertyBuilders.mkClass ClassLiterals.``is-col-from-end-3``

    static member inline isColFromEnd4 =
        PropertyBuilders.mkClass ClassLiterals.``is-col-from-end-4``

    static member inline isColFromEnd5 =
        PropertyBuilders.mkClass ClassLiterals.``is-col-from-end-5``

    static member inline isColFromEnd6 =
        PropertyBuilders.mkClass ClassLiterals.``is-col-from-end-6``

    static member inline isColFromEnd7 =
        PropertyBuilders.mkClass ClassLiterals.``is-col-from-end-7``

    static member inline isColFromEnd8 =
        PropertyBuilders.mkClass ClassLiterals.``is-col-from-end-8``

    static member inline isColFromEnd9 =
        PropertyBuilders.mkClass ClassLiterals.``is-col-from-end-9``

    static member inline isColFromEnd10 =
        PropertyBuilders.mkClass ClassLiterals.``is-col-from-end-10``

    static member inline isColFromEnd11 =
        PropertyBuilders.mkClass ClassLiterals.``is-col-from-end-11``

    static member inline isColFromEnd12 =
        PropertyBuilders.mkClass ClassLiterals.``is-col-from-end-12``

    static member inline isColSpan1 = PropertyBuilders.mkClass ClassLiterals.``is-col-span-1``
    static member inline isColSpan2 = PropertyBuilders.mkClass ClassLiterals.``is-col-span-2``
    static member inline isColSpan3 = PropertyBuilders.mkClass ClassLiterals.``is-col-span-3``
    static member inline isColSpan4 = PropertyBuilders.mkClass ClassLiterals.``is-col-span-4``
    static member inline isColSpan5 = PropertyBuilders.mkClass ClassLiterals.``is-col-span-5``
    static member inline isColSpan6 = PropertyBuilders.mkClass ClassLiterals.``is-col-span-6``
    static member inline isColSpan7 = PropertyBuilders.mkClass ClassLiterals.``is-col-span-7``
    static member inline isColSpan8 = PropertyBuilders.mkClass ClassLiterals.``is-col-span-8``
    static member inline isColSpan9 = PropertyBuilders.mkClass ClassLiterals.``is-col-span-9``
    static member inline isColSpan10 = PropertyBuilders.mkClass ClassLiterals.``is-col-span-10``
    static member inline isColSpan11 = PropertyBuilders.mkClass ClassLiterals.``is-col-span-11``
    static member inline isColSpan12 = PropertyBuilders.mkClass ClassLiterals.``is-col-span-12``
    static member inline isRowStart1 = PropertyBuilders.mkClass ClassLiterals.``is-row-start-1``
    static member inline isRowStart2 = PropertyBuilders.mkClass ClassLiterals.``is-row-start-2``
    static member inline isRowStart3 = PropertyBuilders.mkClass ClassLiterals.``is-row-start-3``
    static member inline isRowStart4 = PropertyBuilders.mkClass ClassLiterals.``is-row-start-4``
    static member inline isRowStart5 = PropertyBuilders.mkClass ClassLiterals.``is-row-start-5``
    static member inline isRowStart6 = PropertyBuilders.mkClass ClassLiterals.``is-row-start-6``
    static member inline isRowStart7 = PropertyBuilders.mkClass ClassLiterals.``is-row-start-7``
    static member inline isRowStart8 = PropertyBuilders.mkClass ClassLiterals.``is-row-start-8``
    static member inline isRowStart9 = PropertyBuilders.mkClass ClassLiterals.``is-row-start-9``
    static member inline isRowStart10 = PropertyBuilders.mkClass ClassLiterals.``is-row-start-10``
    static member inline isRowStart11 = PropertyBuilders.mkClass ClassLiterals.``is-row-start-11``
    static member inline isRowStart12 = PropertyBuilders.mkClass ClassLiterals.``is-row-start-12``

    static member inline isRowFromEnd1 =
        PropertyBuilders.mkClass ClassLiterals.``is-row-from-end-1``

    static member inline isRowFromEnd2 =
        PropertyBuilders.mkClass ClassLiterals.``is-row-from-end-2``

    static member inline isRowFromEnd3 =
        PropertyBuilders.mkClass ClassLiterals.``is-row-from-end-3``

    static member inline isRowFromEnd4 =
        PropertyBuilders.mkClass ClassLiterals.``is-row-from-end-4``

    static member inline isRowFromEnd5 =
        PropertyBuilders.mkClass ClassLiterals.``is-row-from-end-5``

    static member inline isRowFromEnd6 =
        PropertyBuilders.mkClass ClassLiterals.``is-row-from-end-6``

    static member inline isRowFromEnd7 =
        PropertyBuilders.mkClass ClassLiterals.``is-row-from-end-7``

    static member inline isRowFromEnd8 =
        PropertyBuilders.mkClass ClassLiterals.``is-row-from-end-8``

    static member inline isRowFromEnd9 =
        PropertyBuilders.mkClass ClassLiterals.``is-row-from-end-9``

    static member inline isRowFromEnd10 =
        PropertyBuilders.mkClass ClassLiterals.``is-row-from-end-10``

    static member inline isRowFromEnd11 =
        PropertyBuilders.mkClass ClassLiterals.``is-row-from-end-11``

    static member inline isRowFromEnd12 =
        PropertyBuilders.mkClass ClassLiterals.``is-row-from-end-12``

    static member inline isRowSpan1 = PropertyBuilders.mkClass ClassLiterals.``is-row-span-1``
    static member inline isRowSpan2 = PropertyBuilders.mkClass ClassLiterals.``is-row-span-2``
    static member inline isRowSpan3 = PropertyBuilders.mkClass ClassLiterals.``is-row-span-3``
    static member inline isRowSpan4 = PropertyBuilders.mkClass ClassLiterals.``is-row-span-4``
    static member inline isRowSpan5 = PropertyBuilders.mkClass ClassLiterals.``is-row-span-5``
    static member inline isRowSpan6 = PropertyBuilders.mkClass ClassLiterals.``is-row-span-6``
    static member inline isRowSpan7 = PropertyBuilders.mkClass ClassLiterals.``is-row-span-7``
    static member inline isRowSpan8 = PropertyBuilders.mkClass ClassLiterals.``is-row-span-8``
    static member inline isRowSpan9 = PropertyBuilders.mkClass ClassLiterals.``is-row-span-9``
    static member inline isRowSpan10 = PropertyBuilders.mkClass ClassLiterals.``is-row-span-10``
    static member inline isRowSpan11 = PropertyBuilders.mkClass ClassLiterals.``is-row-span-11``
    static member inline isRowSpan12 = PropertyBuilders.mkClass ClassLiterals.``is-row-span-12``

    static member inline isColStart1Mobile =
        PropertyBuilders.mkClass ClassLiterals.``is-col-start-1-mobile``

    static member inline isColStart2Mobile =
        PropertyBuilders.mkClass ClassLiterals.``is-col-start-2-mobile``

    static member inline isColStart3Mobile =
        PropertyBuilders.mkClass ClassLiterals.``is-col-start-3-mobile``

    static member inline isColStart4Mobile =
        PropertyBuilders.mkClass ClassLiterals.``is-col-start-4-mobile``

    static member inline isColStart5Mobile =
        PropertyBuilders.mkClass ClassLiterals.``is-col-start-5-mobile``

    static member inline isColStart6Mobile =
        PropertyBuilders.mkClass ClassLiterals.``is-col-start-6-mobile``

    static member inline isColStart7Mobile =
        PropertyBuilders.mkClass ClassLiterals.``is-col-start-7-mobile``

    static member inline isColStart8Mobile =
        PropertyBuilders.mkClass ClassLiterals.``is-col-start-8-mobile``

    static member inline isColStart9Mobile =
        PropertyBuilders.mkClass ClassLiterals.``is-col-start-9-mobile``

    static member inline isColStart10Mobile =
        PropertyBuilders.mkClass ClassLiterals.``is-col-start-10-mobile``

    static member inline isColStart11Mobile =
        PropertyBuilders.mkClass ClassLiterals.``is-col-start-11-mobile``

    static member inline isColStart12Mobile =
        PropertyBuilders.mkClass ClassLiterals.``is-col-start-12-mobile``

    static member inline isColFromEnd1Mobile =
        PropertyBuilders.mkClass ClassLiterals.``is-col-from-end-1-mobile``

    static member inline isColFromEnd2Mobile =
        PropertyBuilders.mkClass ClassLiterals.``is-col-from-end-2-mobile``

    static member inline isColFromEnd3Mobile =
        PropertyBuilders.mkClass ClassLiterals.``is-col-from-end-3-mobile``

    static member inline isColFromEnd4Mobile =
        PropertyBuilders.mkClass ClassLiterals.``is-col-from-end-4-mobile``

    static member inline isColFromEnd5Mobile =
        PropertyBuilders.mkClass ClassLiterals.``is-col-from-end-5-mobile``

    static member inline isColFromEnd6Mobile =
        PropertyBuilders.mkClass ClassLiterals.``is-col-from-end-6-mobile``

    static member inline isColFromEnd7Mobile =
        PropertyBuilders.mkClass ClassLiterals.``is-col-from-end-7-mobile``

    static member inline isColFromEnd8Mobile =
        PropertyBuilders.mkClass ClassLiterals.``is-col-from-end-8-mobile``

    static member inline isColFromEnd9Mobile =
        PropertyBuilders.mkClass ClassLiterals.``is-col-from-end-9-mobile``

    static member inline isColFromEnd10Mobile =
        PropertyBuilders.mkClass ClassLiterals.``is-col-from-end-10-mobile``

    static member inline isColFromEnd11Mobile =
        PropertyBuilders.mkClass ClassLiterals.``is-col-from-end-11-mobile``

    static member inline isColFromEnd12Mobile =
        PropertyBuilders.mkClass ClassLiterals.``is-col-from-end-12-mobile``

    static member inline isColSpan1Mobile =
        PropertyBuilders.mkClass ClassLiterals.``is-col-span-1-mobile``

    static member inline isColSpan2Mobile =
        PropertyBuilders.mkClass ClassLiterals.``is-col-span-2-mobile``

    static member inline isColSpan3Mobile =
        PropertyBuilders.mkClass ClassLiterals.``is-col-span-3-mobile``

    static member inline isColSpan4Mobile =
        PropertyBuilders.mkClass ClassLiterals.``is-col-span-4-mobile``

    static member inline isColSpan5Mobile =
        PropertyBuilders.mkClass ClassLiterals.``is-col-span-5-mobile``

    static member inline isColSpan6Mobile =
        PropertyBuilders.mkClass ClassLiterals.``is-col-span-6-mobile``

    static member inline isColSpan7Mobile =
        PropertyBuilders.mkClass ClassLiterals.``is-col-span-7-mobile``

    static member inline isColSpan8Mobile =
        PropertyBuilders.mkClass ClassLiterals.``is-col-span-8-mobile``

    static member inline isColSpan9Mobile =
        PropertyBuilders.mkClass ClassLiterals.``is-col-span-9-mobile``

    static member inline isColSpan10Mobile =
        PropertyBuilders.mkClass ClassLiterals.``is-col-span-10-mobile``

    static member inline isColSpan11Mobile =
        PropertyBuilders.mkClass ClassLiterals.``is-col-span-11-mobile``

    static member inline isColSpan12Mobile =
        PropertyBuilders.mkClass ClassLiterals.``is-col-span-12-mobile``

    static member inline isRowStart1Mobile =
        PropertyBuilders.mkClass ClassLiterals.``is-row-start-1-mobile``

    static member inline isRowStart2Mobile =
        PropertyBuilders.mkClass ClassLiterals.``is-row-start-2-mobile``

    static member inline isRowStart3Mobile =
        PropertyBuilders.mkClass ClassLiterals.``is-row-start-3-mobile``

    static member inline isRowStart4Mobile =
        PropertyBuilders.mkClass ClassLiterals.``is-row-start-4-mobile``

    static member inline isRowStart5Mobile =
        PropertyBuilders.mkClass ClassLiterals.``is-row-start-5-mobile``

    static member inline isRowStart6Mobile =
        PropertyBuilders.mkClass ClassLiterals.``is-row-start-6-mobile``

    static member inline isRowStart7Mobile =
        PropertyBuilders.mkClass ClassLiterals.``is-row-start-7-mobile``

    static member inline isRowStart8Mobile =
        PropertyBuilders.mkClass ClassLiterals.``is-row-start-8-mobile``

    static member inline isRowStart9Mobile =
        PropertyBuilders.mkClass ClassLiterals.``is-row-start-9-mobile``

    static member inline isRowStart10Mobile =
        PropertyBuilders.mkClass ClassLiterals.``is-row-start-10-mobile``

    static member inline isRowStart11Mobile =
        PropertyBuilders.mkClass ClassLiterals.``is-row-start-11-mobile``

    static member inline isRowStart12Mobile =
        PropertyBuilders.mkClass ClassLiterals.``is-row-start-12-mobile``

    static member inline isRowFromEnd1Mobile =
        PropertyBuilders.mkClass ClassLiterals.``is-row-from-end-1-mobile``

    static member inline isRowFromEnd2Mobile =
        PropertyBuilders.mkClass ClassLiterals.``is-row-from-end-2-mobile``

    static member inline isRowFromEnd3Mobile =
        PropertyBuilders.mkClass ClassLiterals.``is-row-from-end-3-mobile``

    static member inline isRowFromEnd4Mobile =
        PropertyBuilders.mkClass ClassLiterals.``is-row-from-end-4-mobile``

    static member inline isRowFromEnd5Mobile =
        PropertyBuilders.mkClass ClassLiterals.``is-row-from-end-5-mobile``

    static member inline isRowFromEnd6Mobile =
        PropertyBuilders.mkClass ClassLiterals.``is-row-from-end-6-mobile``

    static member inline isRowFromEnd7Mobile =
        PropertyBuilders.mkClass ClassLiterals.``is-row-from-end-7-mobile``

    static member inline isRowFromEnd8Mobile =
        PropertyBuilders.mkClass ClassLiterals.``is-row-from-end-8-mobile``

    static member inline isRowFromEnd9Mobile =
        PropertyBuilders.mkClass ClassLiterals.``is-row-from-end-9-mobile``

    static member inline isRowFromEnd10Mobile =
        PropertyBuilders.mkClass ClassLiterals.``is-row-from-end-10-mobile``

    static member inline isRowFromEnd11Mobile =
        PropertyBuilders.mkClass ClassLiterals.``is-row-from-end-11-mobile``

    static member inline isRowFromEnd12Mobile =
        PropertyBuilders.mkClass ClassLiterals.``is-row-from-end-12-mobile``

    static member inline isRowSpan1Mobile =
        PropertyBuilders.mkClass ClassLiterals.``is-row-span-1-mobile``

    static member inline isRowSpan2Mobile =
        PropertyBuilders.mkClass ClassLiterals.``is-row-span-2-mobile``

    static member inline isRowSpan3Mobile =
        PropertyBuilders.mkClass ClassLiterals.``is-row-span-3-mobile``

    static member inline isRowSpan4Mobile =
        PropertyBuilders.mkClass ClassLiterals.``is-row-span-4-mobile``

    static member inline isRowSpan5Mobile =
        PropertyBuilders.mkClass ClassLiterals.``is-row-span-5-mobile``

    static member inline isRowSpan6Mobile =
        PropertyBuilders.mkClass ClassLiterals.``is-row-span-6-mobile``

    static member inline isRowSpan7Mobile =
        PropertyBuilders.mkClass ClassLiterals.``is-row-span-7-mobile``

    static member inline isRowSpan8Mobile =
        PropertyBuilders.mkClass ClassLiterals.``is-row-span-8-mobile``

    static member inline isRowSpan9Mobile =
        PropertyBuilders.mkClass ClassLiterals.``is-row-span-9-mobile``

    static member inline isRowSpan10Mobile =
        PropertyBuilders.mkClass ClassLiterals.``is-row-span-10-mobile``

    static member inline isRowSpan11Mobile =
        PropertyBuilders.mkClass ClassLiterals.``is-row-span-11-mobile``

    static member inline isRowSpan12Mobile =
        PropertyBuilders.mkClass ClassLiterals.``is-row-span-12-mobile``

    static member inline isColStart1Tablet =
        PropertyBuilders.mkClass ClassLiterals.``is-col-start-1-tablet``

    static member inline isColStart2Tablet =
        PropertyBuilders.mkClass ClassLiterals.``is-col-start-2-tablet``

    static member inline isColStart3Tablet =
        PropertyBuilders.mkClass ClassLiterals.``is-col-start-3-tablet``

    static member inline isColStart4Tablet =
        PropertyBuilders.mkClass ClassLiterals.``is-col-start-4-tablet``

    static member inline isColStart5Tablet =
        PropertyBuilders.mkClass ClassLiterals.``is-col-start-5-tablet``

    static member inline isColStart6Tablet =
        PropertyBuilders.mkClass ClassLiterals.``is-col-start-6-tablet``

    static member inline isColStart7Tablet =
        PropertyBuilders.mkClass ClassLiterals.``is-col-start-7-tablet``

    static member inline isColStart8Tablet =
        PropertyBuilders.mkClass ClassLiterals.``is-col-start-8-tablet``

    static member inline isColStart9Tablet =
        PropertyBuilders.mkClass ClassLiterals.``is-col-start-9-tablet``

    static member inline isColStart10Tablet =
        PropertyBuilders.mkClass ClassLiterals.``is-col-start-10-tablet``

    static member inline isColStart11Tablet =
        PropertyBuilders.mkClass ClassLiterals.``is-col-start-11-tablet``

    static member inline isColStart12Tablet =
        PropertyBuilders.mkClass ClassLiterals.``is-col-start-12-tablet``

    static member inline isColFromEnd1Tablet =
        PropertyBuilders.mkClass ClassLiterals.``is-col-from-end-1-tablet``

    static member inline isColFromEnd2Tablet =
        PropertyBuilders.mkClass ClassLiterals.``is-col-from-end-2-tablet``

    static member inline isColFromEnd3Tablet =
        PropertyBuilders.mkClass ClassLiterals.``is-col-from-end-3-tablet``

    static member inline isColFromEnd4Tablet =
        PropertyBuilders.mkClass ClassLiterals.``is-col-from-end-4-tablet``

    static member inline isColFromEnd5Tablet =
        PropertyBuilders.mkClass ClassLiterals.``is-col-from-end-5-tablet``

    static member inline isColFromEnd6Tablet =
        PropertyBuilders.mkClass ClassLiterals.``is-col-from-end-6-tablet``

    static member inline isColFromEnd7Tablet =
        PropertyBuilders.mkClass ClassLiterals.``is-col-from-end-7-tablet``

    static member inline isColFromEnd8Tablet =
        PropertyBuilders.mkClass ClassLiterals.``is-col-from-end-8-tablet``

    static member inline isColFromEnd9Tablet =
        PropertyBuilders.mkClass ClassLiterals.``is-col-from-end-9-tablet``

    static member inline isColFromEnd10Tablet =
        PropertyBuilders.mkClass ClassLiterals.``is-col-from-end-10-tablet``

    static member inline isColFromEnd11Tablet =
        PropertyBuilders.mkClass ClassLiterals.``is-col-from-end-11-tablet``

    static member inline isColFromEnd12Tablet =
        PropertyBuilders.mkClass ClassLiterals.``is-col-from-end-12-tablet``

    static member inline isColSpan1Tablet =
        PropertyBuilders.mkClass ClassLiterals.``is-col-span-1-tablet``

    static member inline isColSpan2Tablet =
        PropertyBuilders.mkClass ClassLiterals.``is-col-span-2-tablet``

    static member inline isColSpan3Tablet =
        PropertyBuilders.mkClass ClassLiterals.``is-col-span-3-tablet``

    static member inline isColSpan4Tablet =
        PropertyBuilders.mkClass ClassLiterals.``is-col-span-4-tablet``

    static member inline isColSpan5Tablet =
        PropertyBuilders.mkClass ClassLiterals.``is-col-span-5-tablet``

    static member inline isColSpan6Tablet =
        PropertyBuilders.mkClass ClassLiterals.``is-col-span-6-tablet``

    static member inline isColSpan7Tablet =
        PropertyBuilders.mkClass ClassLiterals.``is-col-span-7-tablet``

    static member inline isColSpan8Tablet =
        PropertyBuilders.mkClass ClassLiterals.``is-col-span-8-tablet``

    static member inline isColSpan9Tablet =
        PropertyBuilders.mkClass ClassLiterals.``is-col-span-9-tablet``

    static member inline isColSpan10Tablet =
        PropertyBuilders.mkClass ClassLiterals.``is-col-span-10-tablet``

    static member inline isColSpan11Tablet =
        PropertyBuilders.mkClass ClassLiterals.``is-col-span-11-tablet``

    static member inline isColSpan12Tablet =
        PropertyBuilders.mkClass ClassLiterals.``is-col-span-12-tablet``

    static member inline isRowStart1Tablet =
        PropertyBuilders.mkClass ClassLiterals.``is-row-start-1-tablet``

    static member inline isRowStart2Tablet =
        PropertyBuilders.mkClass ClassLiterals.``is-row-start-2-tablet``

    static member inline isRowStart3Tablet =
        PropertyBuilders.mkClass ClassLiterals.``is-row-start-3-tablet``

    static member inline isRowStart4Tablet =
        PropertyBuilders.mkClass ClassLiterals.``is-row-start-4-tablet``

    static member inline isRowStart5Tablet =
        PropertyBuilders.mkClass ClassLiterals.``is-row-start-5-tablet``

    static member inline isRowStart6Tablet =
        PropertyBuilders.mkClass ClassLiterals.``is-row-start-6-tablet``

    static member inline isRowStart7Tablet =
        PropertyBuilders.mkClass ClassLiterals.``is-row-start-7-tablet``

    static member inline isRowStart8Tablet =
        PropertyBuilders.mkClass ClassLiterals.``is-row-start-8-tablet``

    static member inline isRowStart9Tablet =
        PropertyBuilders.mkClass ClassLiterals.``is-row-start-9-tablet``

    static member inline isRowStart10Tablet =
        PropertyBuilders.mkClass ClassLiterals.``is-row-start-10-tablet``

    static member inline isRowStart11Tablet =
        PropertyBuilders.mkClass ClassLiterals.``is-row-start-11-tablet``

    static member inline isRowStart12Tablet =
        PropertyBuilders.mkClass ClassLiterals.``is-row-start-12-tablet``

    static member inline isRowFromEnd1Tablet =
        PropertyBuilders.mkClass ClassLiterals.``is-row-from-end-1-tablet``

    static member inline isRowFromEnd2Tablet =
        PropertyBuilders.mkClass ClassLiterals.``is-row-from-end-2-tablet``

    static member inline isRowFromEnd3Tablet =
        PropertyBuilders.mkClass ClassLiterals.``is-row-from-end-3-tablet``

    static member inline isRowFromEnd4Tablet =
        PropertyBuilders.mkClass ClassLiterals.``is-row-from-end-4-tablet``

    static member inline isRowFromEnd5Tablet =
        PropertyBuilders.mkClass ClassLiterals.``is-row-from-end-5-tablet``

    static member inline isRowFromEnd6Tablet =
        PropertyBuilders.mkClass ClassLiterals.``is-row-from-end-6-tablet``

    static member inline isRowFromEnd7Tablet =
        PropertyBuilders.mkClass ClassLiterals.``is-row-from-end-7-tablet``

    static member inline isRowFromEnd8Tablet =
        PropertyBuilders.mkClass ClassLiterals.``is-row-from-end-8-tablet``

    static member inline isRowFromEnd9Tablet =
        PropertyBuilders.mkClass ClassLiterals.``is-row-from-end-9-tablet``

    static member inline isRowFromEnd10Tablet =
        PropertyBuilders.mkClass ClassLiterals.``is-row-from-end-10-tablet``

    static member inline isRowFromEnd11Tablet =
        PropertyBuilders.mkClass ClassLiterals.``is-row-from-end-11-tablet``

    static member inline isRowFromEnd12Tablet =
        PropertyBuilders.mkClass ClassLiterals.``is-row-from-end-12-tablet``

    static member inline isRowSpan1Tablet =
        PropertyBuilders.mkClass ClassLiterals.``is-row-span-1-tablet``

    static member inline isRowSpan2Tablet =
        PropertyBuilders.mkClass ClassLiterals.``is-row-span-2-tablet``

    static member inline isRowSpan3Tablet =
        PropertyBuilders.mkClass ClassLiterals.``is-row-span-3-tablet``

    static member inline isRowSpan4Tablet =
        PropertyBuilders.mkClass ClassLiterals.``is-row-span-4-tablet``

    static member inline isRowSpan5Tablet =
        PropertyBuilders.mkClass ClassLiterals.``is-row-span-5-tablet``

    static member inline isRowSpan6Tablet =
        PropertyBuilders.mkClass ClassLiterals.``is-row-span-6-tablet``

    static member inline isRowSpan7Tablet =
        PropertyBuilders.mkClass ClassLiterals.``is-row-span-7-tablet``

    static member inline isRowSpan8Tablet =
        PropertyBuilders.mkClass ClassLiterals.``is-row-span-8-tablet``

    static member inline isRowSpan9Tablet =
        PropertyBuilders.mkClass ClassLiterals.``is-row-span-9-tablet``

    static member inline isRowSpan10Tablet =
        PropertyBuilders.mkClass ClassLiterals.``is-row-span-10-tablet``

    static member inline isRowSpan11Tablet =
        PropertyBuilders.mkClass ClassLiterals.``is-row-span-11-tablet``

    static member inline isRowSpan12Tablet =
        PropertyBuilders.mkClass ClassLiterals.``is-row-span-12-tablet``

    static member inline isColStart1TabletOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-col-start-1-tablet-only``

    static member inline isColStart2TabletOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-col-start-2-tablet-only``

    static member inline isColStart3TabletOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-col-start-3-tablet-only``

    static member inline isColStart4TabletOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-col-start-4-tablet-only``

    static member inline isColStart5TabletOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-col-start-5-tablet-only``

    static member inline isColStart6TabletOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-col-start-6-tablet-only``

    static member inline isColStart7TabletOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-col-start-7-tablet-only``

    static member inline isColStart8TabletOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-col-start-8-tablet-only``

    static member inline isColStart9TabletOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-col-start-9-tablet-only``

    static member inline isColStart10TabletOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-col-start-10-tablet-only``

    static member inline isColStart11TabletOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-col-start-11-tablet-only``

    static member inline isColStart12TabletOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-col-start-12-tablet-only``

    static member inline isColFromEnd1TabletOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-col-from-end-1-tablet-only``

    static member inline isColFromEnd2TabletOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-col-from-end-2-tablet-only``

    static member inline isColFromEnd3TabletOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-col-from-end-3-tablet-only``

    static member inline isColFromEnd4TabletOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-col-from-end-4-tablet-only``

    static member inline isColFromEnd5TabletOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-col-from-end-5-tablet-only``

    static member inline isColFromEnd6TabletOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-col-from-end-6-tablet-only``

    static member inline isColFromEnd7TabletOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-col-from-end-7-tablet-only``

    static member inline isColFromEnd8TabletOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-col-from-end-8-tablet-only``

    static member inline isColFromEnd9TabletOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-col-from-end-9-tablet-only``

    static member inline isColFromEnd10TabletOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-col-from-end-10-tablet-only``

    static member inline isColFromEnd11TabletOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-col-from-end-11-tablet-only``

    static member inline isColFromEnd12TabletOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-col-from-end-12-tablet-only``

    static member inline isColSpan1TabletOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-col-span-1-tablet-only``

    static member inline isColSpan2TabletOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-col-span-2-tablet-only``

    static member inline isColSpan3TabletOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-col-span-3-tablet-only``

    static member inline isColSpan4TabletOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-col-span-4-tablet-only``

    static member inline isColSpan5TabletOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-col-span-5-tablet-only``

    static member inline isColSpan6TabletOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-col-span-6-tablet-only``

    static member inline isColSpan7TabletOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-col-span-7-tablet-only``

    static member inline isColSpan8TabletOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-col-span-8-tablet-only``

    static member inline isColSpan9TabletOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-col-span-9-tablet-only``

    static member inline isColSpan10TabletOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-col-span-10-tablet-only``

    static member inline isColSpan11TabletOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-col-span-11-tablet-only``

    static member inline isColSpan12TabletOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-col-span-12-tablet-only``

    static member inline isRowStart1TabletOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-row-start-1-tablet-only``

    static member inline isRowStart2TabletOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-row-start-2-tablet-only``

    static member inline isRowStart3TabletOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-row-start-3-tablet-only``

    static member inline isRowStart4TabletOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-row-start-4-tablet-only``

    static member inline isRowStart5TabletOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-row-start-5-tablet-only``

    static member inline isRowStart6TabletOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-row-start-6-tablet-only``

    static member inline isRowStart7TabletOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-row-start-7-tablet-only``

    static member inline isRowStart8TabletOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-row-start-8-tablet-only``

    static member inline isRowStart9TabletOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-row-start-9-tablet-only``

    static member inline isRowStart10TabletOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-row-start-10-tablet-only``

    static member inline isRowStart11TabletOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-row-start-11-tablet-only``

    static member inline isRowStart12TabletOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-row-start-12-tablet-only``

    static member inline isRowFromEnd1TabletOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-row-from-end-1-tablet-only``

    static member inline isRowFromEnd2TabletOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-row-from-end-2-tablet-only``

    static member inline isRowFromEnd3TabletOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-row-from-end-3-tablet-only``

    static member inline isRowFromEnd4TabletOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-row-from-end-4-tablet-only``

    static member inline isRowFromEnd5TabletOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-row-from-end-5-tablet-only``

    static member inline isRowFromEnd6TabletOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-row-from-end-6-tablet-only``

    static member inline isRowFromEnd7TabletOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-row-from-end-7-tablet-only``

    static member inline isRowFromEnd8TabletOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-row-from-end-8-tablet-only``

    static member inline isRowFromEnd9TabletOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-row-from-end-9-tablet-only``

    static member inline isRowFromEnd10TabletOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-row-from-end-10-tablet-only``

    static member inline isRowFromEnd11TabletOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-row-from-end-11-tablet-only``

    static member inline isRowFromEnd12TabletOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-row-from-end-12-tablet-only``

    static member inline isRowSpan1TabletOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-row-span-1-tablet-only``

    static member inline isRowSpan2TabletOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-row-span-2-tablet-only``

    static member inline isRowSpan3TabletOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-row-span-3-tablet-only``

    static member inline isRowSpan4TabletOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-row-span-4-tablet-only``

    static member inline isRowSpan5TabletOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-row-span-5-tablet-only``

    static member inline isRowSpan6TabletOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-row-span-6-tablet-only``

    static member inline isRowSpan7TabletOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-row-span-7-tablet-only``

    static member inline isRowSpan8TabletOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-row-span-8-tablet-only``

    static member inline isRowSpan9TabletOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-row-span-9-tablet-only``

    static member inline isRowSpan10TabletOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-row-span-10-tablet-only``

    static member inline isRowSpan11TabletOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-row-span-11-tablet-only``

    static member inline isRowSpan12TabletOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-row-span-12-tablet-only``

    static member inline isColStart1Desktop =
        PropertyBuilders.mkClass ClassLiterals.``is-col-start-1-desktop``

    static member inline isColStart2Desktop =
        PropertyBuilders.mkClass ClassLiterals.``is-col-start-2-desktop``

    static member inline isColStart3Desktop =
        PropertyBuilders.mkClass ClassLiterals.``is-col-start-3-desktop``

    static member inline isColStart4Desktop =
        PropertyBuilders.mkClass ClassLiterals.``is-col-start-4-desktop``

    static member inline isColStart5Desktop =
        PropertyBuilders.mkClass ClassLiterals.``is-col-start-5-desktop``

    static member inline isColStart6Desktop =
        PropertyBuilders.mkClass ClassLiterals.``is-col-start-6-desktop``

    static member inline isColStart7Desktop =
        PropertyBuilders.mkClass ClassLiterals.``is-col-start-7-desktop``

    static member inline isColStart8Desktop =
        PropertyBuilders.mkClass ClassLiterals.``is-col-start-8-desktop``

    static member inline isColStart9Desktop =
        PropertyBuilders.mkClass ClassLiterals.``is-col-start-9-desktop``

    static member inline isColStart10Desktop =
        PropertyBuilders.mkClass ClassLiterals.``is-col-start-10-desktop``

    static member inline isColStart11Desktop =
        PropertyBuilders.mkClass ClassLiterals.``is-col-start-11-desktop``

    static member inline isColStart12Desktop =
        PropertyBuilders.mkClass ClassLiterals.``is-col-start-12-desktop``

    static member inline isColFromEnd1Desktop =
        PropertyBuilders.mkClass ClassLiterals.``is-col-from-end-1-desktop``

    static member inline isColFromEnd2Desktop =
        PropertyBuilders.mkClass ClassLiterals.``is-col-from-end-2-desktop``

    static member inline isColFromEnd3Desktop =
        PropertyBuilders.mkClass ClassLiterals.``is-col-from-end-3-desktop``

    static member inline isColFromEnd4Desktop =
        PropertyBuilders.mkClass ClassLiterals.``is-col-from-end-4-desktop``

    static member inline isColFromEnd5Desktop =
        PropertyBuilders.mkClass ClassLiterals.``is-col-from-end-5-desktop``

    static member inline isColFromEnd6Desktop =
        PropertyBuilders.mkClass ClassLiterals.``is-col-from-end-6-desktop``

    static member inline isColFromEnd7Desktop =
        PropertyBuilders.mkClass ClassLiterals.``is-col-from-end-7-desktop``

    static member inline isColFromEnd8Desktop =
        PropertyBuilders.mkClass ClassLiterals.``is-col-from-end-8-desktop``

    static member inline isColFromEnd9Desktop =
        PropertyBuilders.mkClass ClassLiterals.``is-col-from-end-9-desktop``

    static member inline isColFromEnd10Desktop =
        PropertyBuilders.mkClass ClassLiterals.``is-col-from-end-10-desktop``

    static member inline isColFromEnd11Desktop =
        PropertyBuilders.mkClass ClassLiterals.``is-col-from-end-11-desktop``

    static member inline isColFromEnd12Desktop =
        PropertyBuilders.mkClass ClassLiterals.``is-col-from-end-12-desktop``

    static member inline isColSpan1Desktop =
        PropertyBuilders.mkClass ClassLiterals.``is-col-span-1-desktop``

    static member inline isColSpan2Desktop =
        PropertyBuilders.mkClass ClassLiterals.``is-col-span-2-desktop``

    static member inline isColSpan3Desktop =
        PropertyBuilders.mkClass ClassLiterals.``is-col-span-3-desktop``

    static member inline isColSpan4Desktop =
        PropertyBuilders.mkClass ClassLiterals.``is-col-span-4-desktop``

    static member inline isColSpan5Desktop =
        PropertyBuilders.mkClass ClassLiterals.``is-col-span-5-desktop``

    static member inline isColSpan6Desktop =
        PropertyBuilders.mkClass ClassLiterals.``is-col-span-6-desktop``

    static member inline isColSpan7Desktop =
        PropertyBuilders.mkClass ClassLiterals.``is-col-span-7-desktop``

    static member inline isColSpan8Desktop =
        PropertyBuilders.mkClass ClassLiterals.``is-col-span-8-desktop``

    static member inline isColSpan9Desktop =
        PropertyBuilders.mkClass ClassLiterals.``is-col-span-9-desktop``

    static member inline isColSpan10Desktop =
        PropertyBuilders.mkClass ClassLiterals.``is-col-span-10-desktop``

    static member inline isColSpan11Desktop =
        PropertyBuilders.mkClass ClassLiterals.``is-col-span-11-desktop``

    static member inline isColSpan12Desktop =
        PropertyBuilders.mkClass ClassLiterals.``is-col-span-12-desktop``

    static member inline isRowStart1Desktop =
        PropertyBuilders.mkClass ClassLiterals.``is-row-start-1-desktop``

    static member inline isRowStart2Desktop =
        PropertyBuilders.mkClass ClassLiterals.``is-row-start-2-desktop``

    static member inline isRowStart3Desktop =
        PropertyBuilders.mkClass ClassLiterals.``is-row-start-3-desktop``

    static member inline isRowStart4Desktop =
        PropertyBuilders.mkClass ClassLiterals.``is-row-start-4-desktop``

    static member inline isRowStart5Desktop =
        PropertyBuilders.mkClass ClassLiterals.``is-row-start-5-desktop``

    static member inline isRowStart6Desktop =
        PropertyBuilders.mkClass ClassLiterals.``is-row-start-6-desktop``

    static member inline isRowStart7Desktop =
        PropertyBuilders.mkClass ClassLiterals.``is-row-start-7-desktop``

    static member inline isRowStart8Desktop =
        PropertyBuilders.mkClass ClassLiterals.``is-row-start-8-desktop``

    static member inline isRowStart9Desktop =
        PropertyBuilders.mkClass ClassLiterals.``is-row-start-9-desktop``

    static member inline isRowStart10Desktop =
        PropertyBuilders.mkClass ClassLiterals.``is-row-start-10-desktop``

    static member inline isRowStart11Desktop =
        PropertyBuilders.mkClass ClassLiterals.``is-row-start-11-desktop``

    static member inline isRowStart12Desktop =
        PropertyBuilders.mkClass ClassLiterals.``is-row-start-12-desktop``

    static member inline isRowFromEnd1Desktop =
        PropertyBuilders.mkClass ClassLiterals.``is-row-from-end-1-desktop``

    static member inline isRowFromEnd2Desktop =
        PropertyBuilders.mkClass ClassLiterals.``is-row-from-end-2-desktop``

    static member inline isRowFromEnd3Desktop =
        PropertyBuilders.mkClass ClassLiterals.``is-row-from-end-3-desktop``

    static member inline isRowFromEnd4Desktop =
        PropertyBuilders.mkClass ClassLiterals.``is-row-from-end-4-desktop``

    static member inline isRowFromEnd5Desktop =
        PropertyBuilders.mkClass ClassLiterals.``is-row-from-end-5-desktop``

    static member inline isRowFromEnd6Desktop =
        PropertyBuilders.mkClass ClassLiterals.``is-row-from-end-6-desktop``

    static member inline isRowFromEnd7Desktop =
        PropertyBuilders.mkClass ClassLiterals.``is-row-from-end-7-desktop``

    static member inline isRowFromEnd8Desktop =
        PropertyBuilders.mkClass ClassLiterals.``is-row-from-end-8-desktop``

    static member inline isRowFromEnd9Desktop =
        PropertyBuilders.mkClass ClassLiterals.``is-row-from-end-9-desktop``

    static member inline isRowFromEnd10Desktop =
        PropertyBuilders.mkClass ClassLiterals.``is-row-from-end-10-desktop``

    static member inline isRowFromEnd11Desktop =
        PropertyBuilders.mkClass ClassLiterals.``is-row-from-end-11-desktop``

    static member inline isRowFromEnd12Desktop =
        PropertyBuilders.mkClass ClassLiterals.``is-row-from-end-12-desktop``

    static member inline isRowSpan1Desktop =
        PropertyBuilders.mkClass ClassLiterals.``is-row-span-1-desktop``

    static member inline isRowSpan2Desktop =
        PropertyBuilders.mkClass ClassLiterals.``is-row-span-2-desktop``

    static member inline isRowSpan3Desktop =
        PropertyBuilders.mkClass ClassLiterals.``is-row-span-3-desktop``

    static member inline isRowSpan4Desktop =
        PropertyBuilders.mkClass ClassLiterals.``is-row-span-4-desktop``

    static member inline isRowSpan5Desktop =
        PropertyBuilders.mkClass ClassLiterals.``is-row-span-5-desktop``

    static member inline isRowSpan6Desktop =
        PropertyBuilders.mkClass ClassLiterals.``is-row-span-6-desktop``

    static member inline isRowSpan7Desktop =
        PropertyBuilders.mkClass ClassLiterals.``is-row-span-7-desktop``

    static member inline isRowSpan8Desktop =
        PropertyBuilders.mkClass ClassLiterals.``is-row-span-8-desktop``

    static member inline isRowSpan9Desktop =
        PropertyBuilders.mkClass ClassLiterals.``is-row-span-9-desktop``

    static member inline isRowSpan10Desktop =
        PropertyBuilders.mkClass ClassLiterals.``is-row-span-10-desktop``

    static member inline isRowSpan11Desktop =
        PropertyBuilders.mkClass ClassLiterals.``is-row-span-11-desktop``

    static member inline isRowSpan12Desktop =
        PropertyBuilders.mkClass ClassLiterals.``is-row-span-12-desktop``

    static member inline isColStart1DesktopOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-col-start-1-desktop-only``

    static member inline isColStart2DesktopOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-col-start-2-desktop-only``

    static member inline isColStart3DesktopOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-col-start-3-desktop-only``

    static member inline isColStart4DesktopOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-col-start-4-desktop-only``

    static member inline isColStart5DesktopOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-col-start-5-desktop-only``

    static member inline isColStart6DesktopOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-col-start-6-desktop-only``

    static member inline isColStart7DesktopOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-col-start-7-desktop-only``

    static member inline isColStart8DesktopOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-col-start-8-desktop-only``

    static member inline isColStart9DesktopOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-col-start-9-desktop-only``

    static member inline isColStart10DesktopOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-col-start-10-desktop-only``

    static member inline isColStart11DesktopOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-col-start-11-desktop-only``

    static member inline isColStart12DesktopOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-col-start-12-desktop-only``

    static member inline isColFromEnd1DesktopOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-col-from-end-1-desktop-only``

    static member inline isColFromEnd2DesktopOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-col-from-end-2-desktop-only``

    static member inline isColFromEnd3DesktopOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-col-from-end-3-desktop-only``

    static member inline isColFromEnd4DesktopOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-col-from-end-4-desktop-only``

    static member inline isColFromEnd5DesktopOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-col-from-end-5-desktop-only``

    static member inline isColFromEnd6DesktopOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-col-from-end-6-desktop-only``

    static member inline isColFromEnd7DesktopOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-col-from-end-7-desktop-only``

    static member inline isColFromEnd8DesktopOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-col-from-end-8-desktop-only``

    static member inline isColFromEnd9DesktopOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-col-from-end-9-desktop-only``

    static member inline isColFromEnd10DesktopOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-col-from-end-10-desktop-only``

    static member inline isColFromEnd11DesktopOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-col-from-end-11-desktop-only``

    static member inline isColFromEnd12DesktopOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-col-from-end-12-desktop-only``

    static member inline isColSpan1DesktopOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-col-span-1-desktop-only``

    static member inline isColSpan2DesktopOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-col-span-2-desktop-only``

    static member inline isColSpan3DesktopOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-col-span-3-desktop-only``

    static member inline isColSpan4DesktopOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-col-span-4-desktop-only``

    static member inline isColSpan5DesktopOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-col-span-5-desktop-only``

    static member inline isColSpan6DesktopOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-col-span-6-desktop-only``

    static member inline isColSpan7DesktopOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-col-span-7-desktop-only``

    static member inline isColSpan8DesktopOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-col-span-8-desktop-only``

    static member inline isColSpan9DesktopOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-col-span-9-desktop-only``

    static member inline isColSpan10DesktopOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-col-span-10-desktop-only``

    static member inline isColSpan11DesktopOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-col-span-11-desktop-only``

    static member inline isColSpan12DesktopOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-col-span-12-desktop-only``

    static member inline isRowStart1DesktopOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-row-start-1-desktop-only``

    static member inline isRowStart2DesktopOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-row-start-2-desktop-only``

    static member inline isRowStart3DesktopOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-row-start-3-desktop-only``

    static member inline isRowStart4DesktopOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-row-start-4-desktop-only``

    static member inline isRowStart5DesktopOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-row-start-5-desktop-only``

    static member inline isRowStart6DesktopOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-row-start-6-desktop-only``

    static member inline isRowStart7DesktopOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-row-start-7-desktop-only``

    static member inline isRowStart8DesktopOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-row-start-8-desktop-only``

    static member inline isRowStart9DesktopOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-row-start-9-desktop-only``

    static member inline isRowStart10DesktopOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-row-start-10-desktop-only``

    static member inline isRowStart11DesktopOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-row-start-11-desktop-only``

    static member inline isRowStart12DesktopOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-row-start-12-desktop-only``

    static member inline isRowFromEnd1DesktopOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-row-from-end-1-desktop-only``

    static member inline isRowFromEnd2DesktopOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-row-from-end-2-desktop-only``

    static member inline isRowFromEnd3DesktopOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-row-from-end-3-desktop-only``

    static member inline isRowFromEnd4DesktopOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-row-from-end-4-desktop-only``

    static member inline isRowFromEnd5DesktopOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-row-from-end-5-desktop-only``

    static member inline isRowFromEnd6DesktopOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-row-from-end-6-desktop-only``

    static member inline isRowFromEnd7DesktopOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-row-from-end-7-desktop-only``

    static member inline isRowFromEnd8DesktopOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-row-from-end-8-desktop-only``

    static member inline isRowFromEnd9DesktopOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-row-from-end-9-desktop-only``

    static member inline isRowFromEnd10DesktopOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-row-from-end-10-desktop-only``

    static member inline isRowFromEnd11DesktopOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-row-from-end-11-desktop-only``

    static member inline isRowFromEnd12DesktopOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-row-from-end-12-desktop-only``

    static member inline isRowSpan1DesktopOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-row-span-1-desktop-only``

    static member inline isRowSpan2DesktopOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-row-span-2-desktop-only``

    static member inline isRowSpan3DesktopOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-row-span-3-desktop-only``

    static member inline isRowSpan4DesktopOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-row-span-4-desktop-only``

    static member inline isRowSpan5DesktopOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-row-span-5-desktop-only``

    static member inline isRowSpan6DesktopOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-row-span-6-desktop-only``

    static member inline isRowSpan7DesktopOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-row-span-7-desktop-only``

    static member inline isRowSpan8DesktopOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-row-span-8-desktop-only``

    static member inline isRowSpan9DesktopOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-row-span-9-desktop-only``

    static member inline isRowSpan10DesktopOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-row-span-10-desktop-only``

    static member inline isRowSpan11DesktopOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-row-span-11-desktop-only``

    static member inline isRowSpan12DesktopOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-row-span-12-desktop-only``

    static member inline isColStart1Widescreen =
        PropertyBuilders.mkClass ClassLiterals.``is-col-start-1-widescreen``

    static member inline isColStart2Widescreen =
        PropertyBuilders.mkClass ClassLiterals.``is-col-start-2-widescreen``

    static member inline isColStart3Widescreen =
        PropertyBuilders.mkClass ClassLiterals.``is-col-start-3-widescreen``

    static member inline isColStart4Widescreen =
        PropertyBuilders.mkClass ClassLiterals.``is-col-start-4-widescreen``

    static member inline isColStart5Widescreen =
        PropertyBuilders.mkClass ClassLiterals.``is-col-start-5-widescreen``

    static member inline isColStart6Widescreen =
        PropertyBuilders.mkClass ClassLiterals.``is-col-start-6-widescreen``

    static member inline isColStart7Widescreen =
        PropertyBuilders.mkClass ClassLiterals.``is-col-start-7-widescreen``

    static member inline isColStart8Widescreen =
        PropertyBuilders.mkClass ClassLiterals.``is-col-start-8-widescreen``

    static member inline isColStart9Widescreen =
        PropertyBuilders.mkClass ClassLiterals.``is-col-start-9-widescreen``

    static member inline isColStart10Widescreen =
        PropertyBuilders.mkClass ClassLiterals.``is-col-start-10-widescreen``

    static member inline isColStart11Widescreen =
        PropertyBuilders.mkClass ClassLiterals.``is-col-start-11-widescreen``

    static member inline isColStart12Widescreen =
        PropertyBuilders.mkClass ClassLiterals.``is-col-start-12-widescreen``

    static member inline isColFromEnd1Widescreen =
        PropertyBuilders.mkClass ClassLiterals.``is-col-from-end-1-widescreen``

    static member inline isColFromEnd2Widescreen =
        PropertyBuilders.mkClass ClassLiterals.``is-col-from-end-2-widescreen``

    static member inline isColFromEnd3Widescreen =
        PropertyBuilders.mkClass ClassLiterals.``is-col-from-end-3-widescreen``

    static member inline isColFromEnd4Widescreen =
        PropertyBuilders.mkClass ClassLiterals.``is-col-from-end-4-widescreen``

    static member inline isColFromEnd5Widescreen =
        PropertyBuilders.mkClass ClassLiterals.``is-col-from-end-5-widescreen``

    static member inline isColFromEnd6Widescreen =
        PropertyBuilders.mkClass ClassLiterals.``is-col-from-end-6-widescreen``

    static member inline isColFromEnd7Widescreen =
        PropertyBuilders.mkClass ClassLiterals.``is-col-from-end-7-widescreen``

    static member inline isColFromEnd8Widescreen =
        PropertyBuilders.mkClass ClassLiterals.``is-col-from-end-8-widescreen``

    static member inline isColFromEnd9Widescreen =
        PropertyBuilders.mkClass ClassLiterals.``is-col-from-end-9-widescreen``

    static member inline isColFromEnd10Widescreen =
        PropertyBuilders.mkClass ClassLiterals.``is-col-from-end-10-widescreen``

    static member inline isColFromEnd11Widescreen =
        PropertyBuilders.mkClass ClassLiterals.``is-col-from-end-11-widescreen``

    static member inline isColFromEnd12Widescreen =
        PropertyBuilders.mkClass ClassLiterals.``is-col-from-end-12-widescreen``

    static member inline isColSpan1Widescreen =
        PropertyBuilders.mkClass ClassLiterals.``is-col-span-1-widescreen``

    static member inline isColSpan2Widescreen =
        PropertyBuilders.mkClass ClassLiterals.``is-col-span-2-widescreen``

    static member inline isColSpan3Widescreen =
        PropertyBuilders.mkClass ClassLiterals.``is-col-span-3-widescreen``

    static member inline isColSpan4Widescreen =
        PropertyBuilders.mkClass ClassLiterals.``is-col-span-4-widescreen``

    static member inline isColSpan5Widescreen =
        PropertyBuilders.mkClass ClassLiterals.``is-col-span-5-widescreen``

    static member inline isColSpan6Widescreen =
        PropertyBuilders.mkClass ClassLiterals.``is-col-span-6-widescreen``

    static member inline isColSpan7Widescreen =
        PropertyBuilders.mkClass ClassLiterals.``is-col-span-7-widescreen``

    static member inline isColSpan8Widescreen =
        PropertyBuilders.mkClass ClassLiterals.``is-col-span-8-widescreen``

    static member inline isColSpan9Widescreen =
        PropertyBuilders.mkClass ClassLiterals.``is-col-span-9-widescreen``

    static member inline isColSpan10Widescreen =
        PropertyBuilders.mkClass ClassLiterals.``is-col-span-10-widescreen``

    static member inline isColSpan11Widescreen =
        PropertyBuilders.mkClass ClassLiterals.``is-col-span-11-widescreen``

    static member inline isColSpan12Widescreen =
        PropertyBuilders.mkClass ClassLiterals.``is-col-span-12-widescreen``

    static member inline isRowStart1Widescreen =
        PropertyBuilders.mkClass ClassLiterals.``is-row-start-1-widescreen``

    static member inline isRowStart2Widescreen =
        PropertyBuilders.mkClass ClassLiterals.``is-row-start-2-widescreen``

    static member inline isRowStart3Widescreen =
        PropertyBuilders.mkClass ClassLiterals.``is-row-start-3-widescreen``

    static member inline isRowStart4Widescreen =
        PropertyBuilders.mkClass ClassLiterals.``is-row-start-4-widescreen``

    static member inline isRowStart5Widescreen =
        PropertyBuilders.mkClass ClassLiterals.``is-row-start-5-widescreen``

    static member inline isRowStart6Widescreen =
        PropertyBuilders.mkClass ClassLiterals.``is-row-start-6-widescreen``

    static member inline isRowStart7Widescreen =
        PropertyBuilders.mkClass ClassLiterals.``is-row-start-7-widescreen``

    static member inline isRowStart8Widescreen =
        PropertyBuilders.mkClass ClassLiterals.``is-row-start-8-widescreen``

    static member inline isRowStart9Widescreen =
        PropertyBuilders.mkClass ClassLiterals.``is-row-start-9-widescreen``

    static member inline isRowStart10Widescreen =
        PropertyBuilders.mkClass ClassLiterals.``is-row-start-10-widescreen``

    static member inline isRowStart11Widescreen =
        PropertyBuilders.mkClass ClassLiterals.``is-row-start-11-widescreen``

    static member inline isRowStart12Widescreen =
        PropertyBuilders.mkClass ClassLiterals.``is-row-start-12-widescreen``

    static member inline isRowFromEnd1Widescreen =
        PropertyBuilders.mkClass ClassLiterals.``is-row-from-end-1-widescreen``

    static member inline isRowFromEnd2Widescreen =
        PropertyBuilders.mkClass ClassLiterals.``is-row-from-end-2-widescreen``

    static member inline isRowFromEnd3Widescreen =
        PropertyBuilders.mkClass ClassLiterals.``is-row-from-end-3-widescreen``

    static member inline isRowFromEnd4Widescreen =
        PropertyBuilders.mkClass ClassLiterals.``is-row-from-end-4-widescreen``

    static member inline isRowFromEnd5Widescreen =
        PropertyBuilders.mkClass ClassLiterals.``is-row-from-end-5-widescreen``

    static member inline isRowFromEnd6Widescreen =
        PropertyBuilders.mkClass ClassLiterals.``is-row-from-end-6-widescreen``

    static member inline isRowFromEnd7Widescreen =
        PropertyBuilders.mkClass ClassLiterals.``is-row-from-end-7-widescreen``

    static member inline isRowFromEnd8Widescreen =
        PropertyBuilders.mkClass ClassLiterals.``is-row-from-end-8-widescreen``

    static member inline isRowFromEnd9Widescreen =
        PropertyBuilders.mkClass ClassLiterals.``is-row-from-end-9-widescreen``

    static member inline isRowFromEnd10Widescreen =
        PropertyBuilders.mkClass ClassLiterals.``is-row-from-end-10-widescreen``

    static member inline isRowFromEnd11Widescreen =
        PropertyBuilders.mkClass ClassLiterals.``is-row-from-end-11-widescreen``

    static member inline isRowFromEnd12Widescreen =
        PropertyBuilders.mkClass ClassLiterals.``is-row-from-end-12-widescreen``

    static member inline isRowSpan1Widescreen =
        PropertyBuilders.mkClass ClassLiterals.``is-row-span-1-widescreen``

    static member inline isRowSpan2Widescreen =
        PropertyBuilders.mkClass ClassLiterals.``is-row-span-2-widescreen``

    static member inline isRowSpan3Widescreen =
        PropertyBuilders.mkClass ClassLiterals.``is-row-span-3-widescreen``

    static member inline isRowSpan4Widescreen =
        PropertyBuilders.mkClass ClassLiterals.``is-row-span-4-widescreen``

    static member inline isRowSpan5Widescreen =
        PropertyBuilders.mkClass ClassLiterals.``is-row-span-5-widescreen``

    static member inline isRowSpan6Widescreen =
        PropertyBuilders.mkClass ClassLiterals.``is-row-span-6-widescreen``

    static member inline isRowSpan7Widescreen =
        PropertyBuilders.mkClass ClassLiterals.``is-row-span-7-widescreen``

    static member inline isRowSpan8Widescreen =
        PropertyBuilders.mkClass ClassLiterals.``is-row-span-8-widescreen``

    static member inline isRowSpan9Widescreen =
        PropertyBuilders.mkClass ClassLiterals.``is-row-span-9-widescreen``

    static member inline isRowSpan10Widescreen =
        PropertyBuilders.mkClass ClassLiterals.``is-row-span-10-widescreen``

    static member inline isRowSpan11Widescreen =
        PropertyBuilders.mkClass ClassLiterals.``is-row-span-11-widescreen``

    static member inline isRowSpan12Widescreen =
        PropertyBuilders.mkClass ClassLiterals.``is-row-span-12-widescreen``

    static member inline isColStart1WidescreenOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-col-start-1-widescreen-only``

    static member inline isColStart2WidescreenOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-col-start-2-widescreen-only``

    static member inline isColStart3WidescreenOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-col-start-3-widescreen-only``

    static member inline isColStart4WidescreenOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-col-start-4-widescreen-only``

    static member inline isColStart5WidescreenOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-col-start-5-widescreen-only``

    static member inline isColStart6WidescreenOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-col-start-6-widescreen-only``

    static member inline isColStart7WidescreenOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-col-start-7-widescreen-only``

    static member inline isColStart8WidescreenOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-col-start-8-widescreen-only``

    static member inline isColStart9WidescreenOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-col-start-9-widescreen-only``

    static member inline isColStart10WidescreenOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-col-start-10-widescreen-only``

    static member inline isColStart11WidescreenOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-col-start-11-widescreen-only``

    static member inline isColStart12WidescreenOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-col-start-12-widescreen-only``

    static member inline isColFromEnd1WidescreenOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-col-from-end-1-widescreen-only``

    static member inline isColFromEnd2WidescreenOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-col-from-end-2-widescreen-only``

    static member inline isColFromEnd3WidescreenOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-col-from-end-3-widescreen-only``

    static member inline isColFromEnd4WidescreenOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-col-from-end-4-widescreen-only``

    static member inline isColFromEnd5WidescreenOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-col-from-end-5-widescreen-only``

    static member inline isColFromEnd6WidescreenOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-col-from-end-6-widescreen-only``

    static member inline isColFromEnd7WidescreenOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-col-from-end-7-widescreen-only``

    static member inline isColFromEnd8WidescreenOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-col-from-end-8-widescreen-only``

    static member inline isColFromEnd9WidescreenOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-col-from-end-9-widescreen-only``

    static member inline isColFromEnd10WidescreenOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-col-from-end-10-widescreen-only``

    static member inline isColFromEnd11WidescreenOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-col-from-end-11-widescreen-only``

    static member inline isColFromEnd12WidescreenOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-col-from-end-12-widescreen-only``

    static member inline isColSpan1WidescreenOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-col-span-1-widescreen-only``

    static member inline isColSpan2WidescreenOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-col-span-2-widescreen-only``

    static member inline isColSpan3WidescreenOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-col-span-3-widescreen-only``

    static member inline isColSpan4WidescreenOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-col-span-4-widescreen-only``

    static member inline isColSpan5WidescreenOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-col-span-5-widescreen-only``

    static member inline isColSpan6WidescreenOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-col-span-6-widescreen-only``

    static member inline isColSpan7WidescreenOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-col-span-7-widescreen-only``

    static member inline isColSpan8WidescreenOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-col-span-8-widescreen-only``

    static member inline isColSpan9WidescreenOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-col-span-9-widescreen-only``

    static member inline isColSpan10WidescreenOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-col-span-10-widescreen-only``

    static member inline isColSpan11WidescreenOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-col-span-11-widescreen-only``

    static member inline isColSpan12WidescreenOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-col-span-12-widescreen-only``

    static member inline isRowStart1WidescreenOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-row-start-1-widescreen-only``

    static member inline isRowStart2WidescreenOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-row-start-2-widescreen-only``

    static member inline isRowStart3WidescreenOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-row-start-3-widescreen-only``

    static member inline isRowStart4WidescreenOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-row-start-4-widescreen-only``

    static member inline isRowStart5WidescreenOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-row-start-5-widescreen-only``

    static member inline isRowStart6WidescreenOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-row-start-6-widescreen-only``

    static member inline isRowStart7WidescreenOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-row-start-7-widescreen-only``

    static member inline isRowStart8WidescreenOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-row-start-8-widescreen-only``

    static member inline isRowStart9WidescreenOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-row-start-9-widescreen-only``

    static member inline isRowStart10WidescreenOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-row-start-10-widescreen-only``

    static member inline isRowStart11WidescreenOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-row-start-11-widescreen-only``

    static member inline isRowStart12WidescreenOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-row-start-12-widescreen-only``

    static member inline isRowFromEnd1WidescreenOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-row-from-end-1-widescreen-only``

    static member inline isRowFromEnd2WidescreenOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-row-from-end-2-widescreen-only``

    static member inline isRowFromEnd3WidescreenOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-row-from-end-3-widescreen-only``

    static member inline isRowFromEnd4WidescreenOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-row-from-end-4-widescreen-only``

    static member inline isRowFromEnd5WidescreenOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-row-from-end-5-widescreen-only``

    static member inline isRowFromEnd6WidescreenOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-row-from-end-6-widescreen-only``

    static member inline isRowFromEnd7WidescreenOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-row-from-end-7-widescreen-only``

    static member inline isRowFromEnd8WidescreenOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-row-from-end-8-widescreen-only``

    static member inline isRowFromEnd9WidescreenOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-row-from-end-9-widescreen-only``

    static member inline isRowFromEnd10WidescreenOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-row-from-end-10-widescreen-only``

    static member inline isRowFromEnd11WidescreenOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-row-from-end-11-widescreen-only``

    static member inline isRowFromEnd12WidescreenOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-row-from-end-12-widescreen-only``

    static member inline isRowSpan1WidescreenOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-row-span-1-widescreen-only``

    static member inline isRowSpan2WidescreenOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-row-span-2-widescreen-only``

    static member inline isRowSpan3WidescreenOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-row-span-3-widescreen-only``

    static member inline isRowSpan4WidescreenOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-row-span-4-widescreen-only``

    static member inline isRowSpan5WidescreenOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-row-span-5-widescreen-only``

    static member inline isRowSpan6WidescreenOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-row-span-6-widescreen-only``

    static member inline isRowSpan7WidescreenOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-row-span-7-widescreen-only``

    static member inline isRowSpan8WidescreenOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-row-span-8-widescreen-only``

    static member inline isRowSpan9WidescreenOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-row-span-9-widescreen-only``

    static member inline isRowSpan10WidescreenOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-row-span-10-widescreen-only``

    static member inline isRowSpan11WidescreenOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-row-span-11-widescreen-only``

    static member inline isRowSpan12WidescreenOnly =
        PropertyBuilders.mkClass ClassLiterals.``is-row-span-12-widescreen-only``

    static member inline isColStart1Fullhd =
        PropertyBuilders.mkClass ClassLiterals.``is-col-start-1-fullhd``

    static member inline isColStart2Fullhd =
        PropertyBuilders.mkClass ClassLiterals.``is-col-start-2-fullhd``

    static member inline isColStart3Fullhd =
        PropertyBuilders.mkClass ClassLiterals.``is-col-start-3-fullhd``

    static member inline isColStart4Fullhd =
        PropertyBuilders.mkClass ClassLiterals.``is-col-start-4-fullhd``

    static member inline isColStart5Fullhd =
        PropertyBuilders.mkClass ClassLiterals.``is-col-start-5-fullhd``

    static member inline isColStart6Fullhd =
        PropertyBuilders.mkClass ClassLiterals.``is-col-start-6-fullhd``

    static member inline isColStart7Fullhd =
        PropertyBuilders.mkClass ClassLiterals.``is-col-start-7-fullhd``

    static member inline isColStart8Fullhd =
        PropertyBuilders.mkClass ClassLiterals.``is-col-start-8-fullhd``

    static member inline isColStart9Fullhd =
        PropertyBuilders.mkClass ClassLiterals.``is-col-start-9-fullhd``

    static member inline isColStart10Fullhd =
        PropertyBuilders.mkClass ClassLiterals.``is-col-start-10-fullhd``

    static member inline isColStart11Fullhd =
        PropertyBuilders.mkClass ClassLiterals.``is-col-start-11-fullhd``

    static member inline isColStart12Fullhd =
        PropertyBuilders.mkClass ClassLiterals.``is-col-start-12-fullhd``

    static member inline isColFromEnd1Fullhd =
        PropertyBuilders.mkClass ClassLiterals.``is-col-from-end-1-fullhd``

    static member inline isColFromEnd2Fullhd =
        PropertyBuilders.mkClass ClassLiterals.``is-col-from-end-2-fullhd``

    static member inline isColFromEnd3Fullhd =
        PropertyBuilders.mkClass ClassLiterals.``is-col-from-end-3-fullhd``

    static member inline isColFromEnd4Fullhd =
        PropertyBuilders.mkClass ClassLiterals.``is-col-from-end-4-fullhd``

    static member inline isColFromEnd5Fullhd =
        PropertyBuilders.mkClass ClassLiterals.``is-col-from-end-5-fullhd``

    static member inline isColFromEnd6Fullhd =
        PropertyBuilders.mkClass ClassLiterals.``is-col-from-end-6-fullhd``

    static member inline isColFromEnd7Fullhd =
        PropertyBuilders.mkClass ClassLiterals.``is-col-from-end-7-fullhd``

    static member inline isColFromEnd8Fullhd =
        PropertyBuilders.mkClass ClassLiterals.``is-col-from-end-8-fullhd``

    static member inline isColFromEnd9Fullhd =
        PropertyBuilders.mkClass ClassLiterals.``is-col-from-end-9-fullhd``

    static member inline isColFromEnd10Fullhd =
        PropertyBuilders.mkClass ClassLiterals.``is-col-from-end-10-fullhd``

    static member inline isColFromEnd11Fullhd =
        PropertyBuilders.mkClass ClassLiterals.``is-col-from-end-11-fullhd``

    static member inline isColFromEnd12Fullhd =
        PropertyBuilders.mkClass ClassLiterals.``is-col-from-end-12-fullhd``

    static member inline isColSpan1Fullhd =
        PropertyBuilders.mkClass ClassLiterals.``is-col-span-1-fullhd``

    static member inline isColSpan2Fullhd =
        PropertyBuilders.mkClass ClassLiterals.``is-col-span-2-fullhd``

    static member inline isColSpan3Fullhd =
        PropertyBuilders.mkClass ClassLiterals.``is-col-span-3-fullhd``

    static member inline isColSpan4Fullhd =
        PropertyBuilders.mkClass ClassLiterals.``is-col-span-4-fullhd``

    static member inline isColSpan5Fullhd =
        PropertyBuilders.mkClass ClassLiterals.``is-col-span-5-fullhd``

    static member inline isColSpan6Fullhd =
        PropertyBuilders.mkClass ClassLiterals.``is-col-span-6-fullhd``

    static member inline isColSpan7Fullhd =
        PropertyBuilders.mkClass ClassLiterals.``is-col-span-7-fullhd``

    static member inline isColSpan8Fullhd =
        PropertyBuilders.mkClass ClassLiterals.``is-col-span-8-fullhd``

    static member inline isColSpan9Fullhd =
        PropertyBuilders.mkClass ClassLiterals.``is-col-span-9-fullhd``

    static member inline isColSpan10Fullhd =
        PropertyBuilders.mkClass ClassLiterals.``is-col-span-10-fullhd``

    static member inline isColSpan11Fullhd =
        PropertyBuilders.mkClass ClassLiterals.``is-col-span-11-fullhd``

    static member inline isColSpan12Fullhd =
        PropertyBuilders.mkClass ClassLiterals.``is-col-span-12-fullhd``

    static member inline isRowStart1Fullhd =
        PropertyBuilders.mkClass ClassLiterals.``is-row-start-1-fullhd``

    static member inline isRowStart2Fullhd =
        PropertyBuilders.mkClass ClassLiterals.``is-row-start-2-fullhd``

    static member inline isRowStart3Fullhd =
        PropertyBuilders.mkClass ClassLiterals.``is-row-start-3-fullhd``

    static member inline isRowStart4Fullhd =
        PropertyBuilders.mkClass ClassLiterals.``is-row-start-4-fullhd``

    static member inline isRowStart5Fullhd =
        PropertyBuilders.mkClass ClassLiterals.``is-row-start-5-fullhd``

    static member inline isRowStart6Fullhd =
        PropertyBuilders.mkClass ClassLiterals.``is-row-start-6-fullhd``

    static member inline isRowStart7Fullhd =
        PropertyBuilders.mkClass ClassLiterals.``is-row-start-7-fullhd``

    static member inline isRowStart8Fullhd =
        PropertyBuilders.mkClass ClassLiterals.``is-row-start-8-fullhd``

    static member inline isRowStart9Fullhd =
        PropertyBuilders.mkClass ClassLiterals.``is-row-start-9-fullhd``

    static member inline isRowStart10Fullhd =
        PropertyBuilders.mkClass ClassLiterals.``is-row-start-10-fullhd``

    static member inline isRowStart11Fullhd =
        PropertyBuilders.mkClass ClassLiterals.``is-row-start-11-fullhd``

    static member inline isRowStart12Fullhd =
        PropertyBuilders.mkClass ClassLiterals.``is-row-start-12-fullhd``

    static member inline isRowFromEnd1Fullhd =
        PropertyBuilders.mkClass ClassLiterals.``is-row-from-end-1-fullhd``

    static member inline isRowFromEnd2Fullhd =
        PropertyBuilders.mkClass ClassLiterals.``is-row-from-end-2-fullhd``

    static member inline isRowFromEnd3Fullhd =
        PropertyBuilders.mkClass ClassLiterals.``is-row-from-end-3-fullhd``

    static member inline isRowFromEnd4Fullhd =
        PropertyBuilders.mkClass ClassLiterals.``is-row-from-end-4-fullhd``

    static member inline isRowFromEnd5Fullhd =
        PropertyBuilders.mkClass ClassLiterals.``is-row-from-end-5-fullhd``

    static member inline isRowFromEnd6Fullhd =
        PropertyBuilders.mkClass ClassLiterals.``is-row-from-end-6-fullhd``

    static member inline isRowFromEnd7Fullhd =
        PropertyBuilders.mkClass ClassLiterals.``is-row-from-end-7-fullhd``

    static member inline isRowFromEnd8Fullhd =
        PropertyBuilders.mkClass ClassLiterals.``is-row-from-end-8-fullhd``

    static member inline isRowFromEnd9Fullhd =
        PropertyBuilders.mkClass ClassLiterals.``is-row-from-end-9-fullhd``

    static member inline isRowFromEnd10Fullhd =
        PropertyBuilders.mkClass ClassLiterals.``is-row-from-end-10-fullhd``

    static member inline isRowFromEnd11Fullhd =
        PropertyBuilders.mkClass ClassLiterals.``is-row-from-end-11-fullhd``

    static member inline isRowFromEnd12Fullhd =
        PropertyBuilders.mkClass ClassLiterals.``is-row-from-end-12-fullhd``

    static member inline isRowSpan1Fullhd =
        PropertyBuilders.mkClass ClassLiterals.``is-row-span-1-fullhd``

    static member inline isRowSpan2Fullhd =
        PropertyBuilders.mkClass ClassLiterals.``is-row-span-2-fullhd``

    static member inline isRowSpan3Fullhd =
        PropertyBuilders.mkClass ClassLiterals.``is-row-span-3-fullhd``

    static member inline isRowSpan4Fullhd =
        PropertyBuilders.mkClass ClassLiterals.``is-row-span-4-fullhd``

    static member inline isRowSpan5Fullhd =
        PropertyBuilders.mkClass ClassLiterals.``is-row-span-5-fullhd``

    static member inline isRowSpan6Fullhd =
        PropertyBuilders.mkClass ClassLiterals.``is-row-span-6-fullhd``

    static member inline isRowSpan7Fullhd =
        PropertyBuilders.mkClass ClassLiterals.``is-row-span-7-fullhd``

    static member inline isRowSpan8Fullhd =
        PropertyBuilders.mkClass ClassLiterals.``is-row-span-8-fullhd``

    static member inline isRowSpan9Fullhd =
        PropertyBuilders.mkClass ClassLiterals.``is-row-span-9-fullhd``

    static member inline isRowSpan10Fullhd =
        PropertyBuilders.mkClass ClassLiterals.``is-row-span-10-fullhd``

    static member inline isRowSpan11Fullhd =
        PropertyBuilders.mkClass ClassLiterals.``is-row-span-11-fullhd``

    static member inline isRowSpan12Fullhd =
        PropertyBuilders.mkClass ClassLiterals.``is-row-span-12-fullhd``
