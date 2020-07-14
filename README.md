# uwp-toast-options

Weirdness...

* Wonky that have to duplicate functionality in OnActivated that's identical to OnLaunched.
* Wonky that you have to register a background task... why not just override OnBackgroundActivated?


Nice things...

* Background activation (aside from registering) is super simple
* Identity just works, nothing to config