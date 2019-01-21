jsPlumb.ready(function () {

    // list of possible anchor locations for the blue source element
    var sourceAnchors = [
        [ 0, 0.5, 0, 0.5 ],
        [ 0, 0.5, 1, 0.5 ],
        [ 1, 0.5, 0, 0.5 ],
        [ 1, 0.5, 1, 0.5 ],
        [ 0.5, 0, 0.5, 0 ],
        [ 0.5, 0, 0.5, 1 ],
        [ 0.5, 1, 0.5, 0 ],
        [ 0.5, 0, 0.5, 1 ]
    ];

    var instance = window.instance = jsPlumb.getInstance({
        // drag options
        DragOptions: { cursor: "pointer", zIndex: 2000 },
        // default to a gradient stroke from blue to green.
        PaintStyle: {
            gradient: { stops: [
                [ 0, "#CCCCCC" ],
                [ 1, "#737373" ]
            ] },
            stroke: "#FF0000",
            strokeWidth: 1
        },
        Container: "canvas"
    });

    // click listener for the enable/disable link in the source box (the blue one).
    jsPlumb.on(document.getElementById("enableDisableSource"), "click", function (e) {
        var sourceDiv = (e.target|| e.srcElement).parentNode;
        var state = instance.toggleSourceEnabled(sourceDiv);
        this.innerHTML = (state ? "disable" : "enable");
        jsPlumb[state ? "removeClass" : "addClass"](sourceDiv, "element-disabled");
        jsPlumbUtil.consume(e);
    });

    // click listener for enable/disable in the small green boxes
    jsPlumb.on(document.getElementById("canvas"), "click", ".enableDisableTarget", function (e) {
        var targetDiv = (e.target || e.srcElement).parentNode;
        var state = instance.toggleTargetEnabled(targetDiv);
        this.innerHTML = (state ? "disable" : "enable");
        jsPlumb[state ? "removeClass" : "addClass"](targetDiv, "element-disabled");
        jsPlumbUtil.consume(e);
    });

    // get the list of ".smallWindow" elements.            
    var smallWindows = jsPlumb.getSelector(".smallWindow");
    // make them draggable
    instance.draggable(smallWindows, {
        filter:".enableDisableTarget"
    });

    // suspend drawing and initialise.
    instance.batch(function () {

        // make 'window1' a connection source. notice the filter and filterExclude parameters: they tell jsPlumb to ignore drags
        // that started on the 'enable/disable' link on the orange window.
        instance.makeSource("sourceWindow1", {
            dropOptions: { hoverClass: "hover" },
            maxConnections: -1,
            endpoint:[ "Dot", { radius: 1, cssClass:"small-orange" } ],
            anchor:sourceAnchors
        });

        // configure the .smallWindows as targets.
        instance.makeTarget(smallWindows, {
            maxConnections: -1,
            anchor:sourceAnchors,
            endpoint:[ "Dot", { radius: 1, cssClass:"large-gray" } ]
        });

        // and finally connect a couple of small windows, just so its obvious what's going on when this demo loads.           
        instance.connect({ source: "sourceWindow1", target: "targetWindow1" });
        instance.connect({ source: "sourceWindow1", target: "targetWindow2" });
        instance.connect({ source: "sourceWindow1", target: "targetWindow3" });
        instance.connect({ source: "sourceWindow1", target: "targetWindow4" });
        instance.connect({ source: "sourceWindow1", target: "targetWindow5" });
        instance.connect({ source: "sourceWindow1", target: "targetWindow6" });
        instance.connect({ source: "sourceWindow1", target: "targetWindow7" });
        instance.connect({ source: "sourceWindow1", target: "targetWindow8" });
        instance.connect({ source: "sourceWindow1", target: "targetWindow9" });
    });

    jsPlumb.fire("jsPlumbDemoLoaded", instance);
});	