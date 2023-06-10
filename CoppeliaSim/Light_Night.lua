
-- Example code
-- local tl=require "Light_Tube"
-- function sysCall_init()
--    tl.Init(name)
-- end
-- function sysCall_actuation()
--
--  end
-----------------------------------------
Light_Night = {}
local night_lamp=0         --store object id
--___________________________________________________________________________________________________________________________________
function Light_Night.init(obj_night_light) 
    night_lamp=sim.getObjectHandle(obj_night_light)
end
--___________________________________________________________________________________________________________________________________
function Light_Night.on()  
    sim.setLightParameters(night_lamp,1,nil,nil,nil)
end
--___________________________________________________________________________________________________________________________________
function Light_Night.off()  
    sim.setLightParameters(night_lamp,0,nil,nil,nil)
end
--___________________________________________________________________________________________________________________________________
return Light_Night