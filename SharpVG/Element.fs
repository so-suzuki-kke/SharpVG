namespace SharpVG

// TODO: Remove file or figure out what needs to be here
type baseElement =
    | Line of line
    | Text of text
    | Image of image
    | Circle of circle
    | Ellipse of ellipse
    | Rect of rect
    | Polygon of points
    | Polyline of points

// TODO: Re-add Style
type element =
    | StyledElement of baseElement * style
    | PlainElement of baseElement

module Element =
    let ofLine line = PlainElement(Line(line))
    let ofText text = PlainElement(Text(text))
    let ofImage image = PlainElement(Image(image))
    let ofCircle circle = PlainElement(Circle(circle))
    let ofEllipse ellipse = PlainElement(Ellipse(ellipse))
    let ofRect rect = PlainElement(Rect(rect))
    let ofPolygon polygon = PlainElement(Polygon(polygon))
    let ofPolyline polyline = PlainElement(Polyline(polyline))

(*
[<AbstractClass>]
type SvgElement(element : Element, style : Style option) =

    member __.Element = element

    member __.Style =
        match element with
            | StyledElement(_, style) -> Some(style)
            | _ -> None

    abstract member Name : string

    abstract member Body : string option
    default __.Body = None

    abstract member Attributes : string

    abstract member toString : string

    default __.toString =
        let name = __.Name
        let body = __.Body
        let attributes = __.Attributes
        let style = __.Style

        let styledAttributes =
            match style with
                | Some(s) -> attributes + " " + SvgStyle(s).toString
                | _ -> attributes

        match body with
            | Some(body) -> "<" + name + " " + styledAttributes + ">" + body + "</" + name + ">"
            | None -> "<" + name + " " + styledAttributes + "/>"

    override __.ToString() = __.toString
*)