# Windows Forms Positioning Tutorial
It's a tutorial for windows forms positioning

# Introduction

In all Windows Forms controls, they there's 4 properties indicates the position of the element relatively to the parent element (Button to Form).

These are: [Left](https://msdn.microsoft.com/en-us/library/system.windows.forms.control.left(v=vs.110).aspx), [Top](https://msdn.microsoft.com/en-us/library/system.windows.forms.control.top(v=vs.110).aspx), [Right](https://msdn.microsoft.com/en-us/library/system.windows.forms.control.right(v=vs.110).aspx), and [Bottom](https://msdn.microsoft.com/en-us/library/system.windows.forms.control.bottom(v=vs.110).aspx),
The Right and Bottom properties are Read Only, their value equals Left + Width and Top + Height respectively.

# How do they work?

In fact they are wrappers on [Location](https://msdn.microsoft.com/en-us/library/system.windows.forms.control.location(v=vs.110).aspx) property, where Left is a wrapper on Location.X, and Top is a wrapper on Location.Y.
Location Propery can be set in the propery window, and will give the same result.

The Left property (as descriped in the documentation):
> An Int32 representing the distance, in pixels, between the __**left edge**__ of the control and the *left edge* of its container's client area.

The Right is a bit different
> An Int32 representing the distance, in pixels, between the __**right edge**__ of the control and the *left edge* of its container's client area

As you see, the Right = Left + Width


The same for Top and Bottom:
> *Top:* An Int32 representing the distance, in pixels, between the __**top edge**__ of the control and the **top edge** of its container's client area.
> *Bottom:* An Int32 representing the distance, in pixels, between the __**bottom edge**__ of the control and the **top edge** of its container's client area.
