module Classes.Grim.NotImplemented
open Schema
open Schema.DamageShorts
module Soldier =
  let theme = GD
  module Skills =
    let notImplemented =
      {
        name="not implemented"
        usage= Active
        tags = [
          Damage bleeding
          Damage cold
          Damage fire
          Damage lightning
          Damage physical
          Damage pierce
          Damage trauma
          Damage weapon
        ]
        mods = []
      }
  open Skills
  let cls = {
    name="Soldier"
    theme=theme
    skills=[
      notImplemented
    ]
  }
module Demolitionist =
  let theme = GD
  module Skills =
    let notImplemented =
      {
        name="not implemented"
        usage= Active
        tags = [
          // Damage bleeding
          Damage burn
          Damage chaos
          // Damage cold
          Damage electrocute
          Damage fire
          Damage lightning
          Damage physical
          Damage pierce
          Damage trauma
          Damage weapon
        ]
        mods = []
      }
  open Skills
  let cls = {
    name="Demolitionist"
    theme=theme
    skills= [
      notImplemented
    ]
  }
module Occultist =
  let theme = GD
  module Skills =
    let notImplemented =
      {
        name="not implemented"
        usage= Active
        tags = [
          Damage acid
          Damage bleeding
          Damage burn
          Damage chaos
          Damage decay
          Damage cold
          Damage electrocute
          Damage fire
          Damage lightning
          Damage physical
        //   Damage pierce
          Damage poison
        //   Damage trauma
          Damage vitality
          Damage weapon
        ]
        mods = []
      }
  open Skills
  let cls = {
    name= "Occultist"
    theme= theme
    skills=[
      notImplemented
    ]
  }
module Nightblade =
  let theme = GD
  module Skills =
    let notImplemented =
      {
        name="not implemented"
        usage= Active
        tags = [
          Damage acid
          Damage bleeding
        //   Damage burn
          Damage chaos
          Damage cold
          Damage decay
        //   Damage electrocute
        //   Damage fire
          Damage frostburn
        //   Damage lightning
          Damage physical
          Damage pierce
          Damage poison
        //   Damage trauma
          Damage vitality
          Damage weapon
        ]
        mods = []
      }
  open Skills
  let cls = {
    name= "Nightblade"
    theme= theme
    skills=[
      notImplemented
    ]
  }
module Arcanist =
  let theme = GD
  module Skills =
    let notImplemented =
      {
        name="not implemented"
        usage= Active
        tags = [
          Damage aether
          // Damage acid
          // Damage bleeding
          Damage burn
          Damage chaos
          Damage cold
          // Damage decay
          Damage electrocute
          Damage fire
          Damage frostburn
          Damage lightning
          // Damage physical
          // Damage pierce
          // Damage poison
        //   Damage trauma
          Damage vitality
          Damage weapon
        ]
        mods = []
      }
  open Skills
  let cls = {
    name= "Arcanist"
    theme= theme
    skills=[
      notImplemented
    ]
  }
module Shaman =
  let theme = GD
  module Skills =
    let notImplemented =
      {
        name="not implemented"
        usage= Active
        tags = [
          // Damage aether
          // Damage acid
          Damage bleeding
          // Damage burn
          // Damage chaos
          Damage cold
          Damage decay
          Damage electrocute
          // Damage fire
          // Damage frostburn
          Damage lightning
          Damage physical
          Damage pierce
          Damage poison
        //   Damage trauma
          Damage vitality
          Damage weapon
        ]
        mods = []
      }
  open Skills
  let cls = {
    name= "Shaman"
    theme= theme
    skills=[
      notImplemented
    ]
  }
module Inquisitor =
  let theme = GD
  module Skills =
    let notImplemented =
      {
        name="not implemented"
        usage= Active
        tags = [
          Damage aether
          // Damage acid
          // Damage bleeding
          Damage burn
          Damage chaos
          Damage cold
          // Damage decay
          Damage electrocute
          Damage fire
          Damage frostburn
          Damage lightning
          Damage physical
          Damage pierce
          // Damage poison
        //   Damage trauma
          Damage vitality
          Damage weapon
        ]
        mods = []
      }
  open Skills
  let cls = {
    name= "Inquisitor"
    theme= theme
    skills=[
      notImplemented
    ]
  }
module Necromancer =
  let theme = GD
  module Skills =
    let notImplemented =
      {
        name="not implemented"
        usage= Active
        tags = [
            Damage aether
            Damage acid
            Damage bleeding
            // Damage burn
            Damage cold
            Damage decay
            // Damage electrocute
            // Damage fire
            // Damage frostburn
            // Damage lightning
            Damage physical
            Damage poison
            Damage pierce
            // Damage trauma
            Damage vitality
            Damage weapon
        ]
        mods = []
      }
  open Skills
  let cls = {
    name="Necromancer"
    theme=theme
    skills=[
      notImplemented
    ]
  }
module Oathkeeper =
  let theme = GD
  module Skills =
    let notImplemented =
      {
        name="not implemented"
        usage= Active
        tags = [
            // Damage aether
            Damage acid
            // Damage bleeding
            Damage burn
            // Damage cold
            // Damage decay
            // Damage electrocute
            Damage fire
            // Damage frostburn
            Damage lightning
            Damage physical
            // Damage poison
            Damage pierce
            Damage trauma
            Damage vitality
            Damage weapon
        ]
        mods = []
      }
  open Skills
  let cls = {
    name="Oathkeeper"
    theme=theme
    skills=[
      notImplemented
    ]
  }