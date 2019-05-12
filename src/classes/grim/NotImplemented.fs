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
        //   Damage acid
        //   Damage bleeding
        //   Damage burn
        //   Damage chaos
        //   Damage decay
        //   Damage cold
        //   Damage electrocute
        //   Damage fire
        //   Damage lightning
        //   Damage physical
        //   Damage pierce
        //   Damage poison
        //   Damage trauma
        //   Damage vitality
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