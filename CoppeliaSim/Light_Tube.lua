
-- Example code
-- local tl=require "Light_Tube"
-- function sysCall_init()
--    tl.Init(name)
-- end
-- function sysCall_actuation()
--
--  end
-----------------------------------------
Light_Tube = {}
local tube_light=0         --store object id
--___________________________________________________________________________________________________________________________________
function Light_Tube.init(obj_tube_light) 
    tube_light=sim.getObjectHandle(obj_tube_light)
end
--___________________________________________________________________________________________________________________________________
function Light_Tube.on()  
    sim.setLightParameters(tube_light,1,nil,nil,nil)
end
--___________________________________________________________________________________________________________________________________
function Light_Tube.off()  
    sim.setLightParameters(tube_light,0,nil,nil,nil)
end
--___________________________________________________________________________________________________________________________________
return Light_Tube