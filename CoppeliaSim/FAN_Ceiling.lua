
-- Example code
-- local fan=require "FAN_Celing"
-- function sysCall_init()
--    fan.Init(name)
-- end
-- function sysCall_actuation()
--
--  end
-----------------------------------------
FAN_Ceiling = {}
local fan=0         --store object id
local state="off"
local speed=10
local rotation=0
--___________________________________________________________________________________________________________________________________
function FAN_Ceiling.init(obj_Fan) 
   fan=sim.getObjectHandle(obj_Fan)
end
--___________________________________________________________________________________________________________________________________
function FAN_Ceiling.process()  
    if(state =="on") then     
        sim.setJointPosition(fan,math.rad(rotation))  
        rotation=rotation+speed
        if(rotation>=360) then  
        rotation=0
        end
    end
end
--___________________________________________________________________________________________________________________________________
function FAN_Ceiling.on()  
    state="on"
end
--___________________________________________________________________________________________________________________________________
function FAN_Ceiling.off()  
    state="off"   
end
--___________________________________________________________________________________________________________________________________
function FAN_Ceiling.speed(fan_speed)  
    speed=fan_speed;
end
--___________________________________________________________________________________________________________________________________
return FAN_Ceiling