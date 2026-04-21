module internal Feliz.Bulma.PropertyBuilders

open Feliz

let inline mkClass (value: string) = PropHelper.mkAttr "className" value
let inline mkType (value: string) = PropHelper.mkAttr "type" value
let inline mkValue (value: int) = PropHelper.mkAttr "value" value
let inline mkMax (value: int) = PropHelper.mkAttr "max" value
