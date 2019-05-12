module Classes.Other.NotImplemented
open Schema
open Schema.DamageShorts
module TerrorKnight =
  let theme = Other
  module Skills =
    let notImplemented =
      {
        name="not implemented"
        usage= Active
        tags = [
        //   Damage bleeding
            Damage burn
            Damage decay
        //   Damage cold
            Damage fire
        //   Damage lightning
            Damage physical
        //   Damage pierce
        //   Damage trauma
            Damage vitality
            Damage weapon
        ]
        mods = []
      }
  open Skills
  let cls = {
    name="Terror Knight"
    theme=theme
    skills=[
      notImplemented
    ]
  }
module Elementalist =
  let theme = Other
  module Skills =
    let notImplemented =
      {
        name="not implemented"
        usage= Active
        tags = [
        //   Damage bleeding
            Damage burn
            // Damage decay
            Damage cold
            Damage electrocute
            Damage fire
            Damage lightning
            Damage physical
        //   Damage pierce
        //   Damage trauma
            // Damage vitality
            Damage weapon
        ]
        mods = []
      }
  open Skills
  let cls = {
    name="Elementalist"
    theme=theme
    skills=[
      notImplemented
    ]
  }
module Outrider =
  let theme = Other
  module Skills =
    let notImplemented =
      {
        name="not implemented"
        usage= Active
        tags = [
            Damage acid
        //   Damage bleeding
            // Damage burn
            // Damage decay
            Damage cold
            // Damage electrocute
            // Damage fire
            Damage frostburn
            // Damage lightning
            Damage physical
        //   Damage pierce
        //   Damage trauma
            Damage vitality
            Damage weapon
        ]
        mods = []
      }
  open Skills
  let cls = {
    name="Outrider"
    theme=theme
    skills=[
      notImplemented
    ]
  }
module Champion =
  let theme = Other
  module Skills =
    let notImplemented =
      {
        name="not implemented"
        usage= Active
        tags = [
            Damage aether
            // Damage acid
        //   Damage bleeding
            // Damage burn
            // Damage decay
            // Damage cold
            Damage electrocute
            // Damage fire
            // Damage frostburn
            Damage lightning
            Damage physical
        //   Damage pierce
            Damage trauma
            // Damage vitality
            Damage weapon
        ]
        mods = []
      }
  open Skills
  let cls = {
    name="Champion"
    theme=theme
    skills=[
      notImplemented
    ]
  }
module Riftstalker =
  let theme = Other
  module Skills =
    let notImplemented =
      {
        name="not implemented"
        usage= Active
        tags = [
            Damage aether
            // Damage acid
        //   Damage bleeding
            // Damage burn
            Damage chaos
            // Damage decay
            // Damage cold
            // Damage electrocute
            // Damage fire
            // Damage frostburn
            Damage lightning
            // Damage physical
            Damage pierce
            // Damage trauma
            // Damage vitality
            Damage weapon
        ]
        mods = []
      }
  open Skills
  let cls = {
    name="Riftstalker"
    theme=theme
    skills=[
      notImplemented
    ]
  }
module Necrotic =
  let theme = Other
  module Skills =
    let notImplemented =
      {
        name="not implemented"
        usage= Active
        tags = [
            // Damage aether
            Damage acid
        //   Damage bleeding
            // Damage burn
            Damage chaos
            // Damage decay
            // Damage cold
            // Damage electrocute
            // Damage fire
            // Damage frostburn
            // Damage lightning
            Damage physical
            Damage pierce
            // Damage trauma
            // Damage vitality
            Damage weapon
        ]
        mods = []
      }
  open Skills
  let cls = {
    name="Necrotic"
    theme=theme
    skills=[
      notImplemented
    ]
  }