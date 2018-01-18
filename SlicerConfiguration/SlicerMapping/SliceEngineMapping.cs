﻿/*
Copyright (c) 2014, Lars Brubaker
All rights reserved.

Redistribution and use in source and binary forms, with or without
modification, are permitted provided that the following conditions are met:

1. Redistributions of source code must retain the above copyright notice, this
   list of conditions and the following disclaimer.
2. Redistributions in binary form must reproduce the above copyright notice,
   this list of conditions and the following disclaimer in the documentation
   and/or other materials provided with the distribution.

THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND
ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED
WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE
DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT OWNER OR CONTRIBUTORS BE LIABLE FOR
ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES
(INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES;
LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND
ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT
(INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS
SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.

The views and conclusions contained in the software and documentation are those
of the authors and should not be interpreted as representing official policies,
either expressed or implied, of the FreeBSD Project.
*/

using System.Collections.Generic;

namespace MatterHackers.MatterControl.SlicerConfiguration
{
	public abstract class SliceEngineMapping
	{
		/// <summary>
		/// Application level settings control MatterControl behaviors but aren't used or passed through to the slice engine. Putting settings
		/// in this list ensures they show up for all slice engines and the lack of a MappedSetting for the engine guarantees that it won't pass
		/// through into the slicer config file
		/// </summary>
		protected HashSet<string> applicationLevelSettings = new HashSet<string>()
		{
			SettingsKey.bed_shape,
			SettingsKey.bed_size,
			SettingsKey.print_center,
			SettingsKey.send_with_checksum,
			SettingsKey.bed_temperature,
			SettingsKey.build_height,
			SettingsKey.cancel_gcode,
			SettingsKey.connect_gcode,
			SettingsKey.write_regex,
			SettingsKey.read_regex,
			SettingsKey.has_fan,
			SettingsKey.has_hardware_leveling,
			SettingsKey.has_heated_bed,
			SettingsKey.has_power_control,
			SettingsKey.has_sd_card_reader,
			SettingsKey.printer_name,
			SettingsKey.auto_connect,
			SettingsKey.backup_firmware_before_update,
			SettingsKey.baud_rate,
			SettingsKey.com_port,
			SettingsKey.filament_cost,
			SettingsKey.filament_density,
			SettingsKey.filament_runout_sensor,
			SettingsKey.leveling_manual_positions,
			SettingsKey.z_probe_z_offset,
			SettingsKey.use_z_probe,
			SettingsKey.z_probe_samples,
			SettingsKey.has_z_probe,
			SettingsKey.has_z_servo,
			SettingsKey.z_probe_xy_offset,
			SettingsKey.z_servo_depolyed_angle,
			SettingsKey.z_servo_retracted_angle,
			SettingsKey.pause_gcode,
			SettingsKey.print_leveling_probe_start,
			SettingsKey.print_leveling_required_to_print,
			SettingsKey.print_leveling_solution,
			SettingsKey.recover_first_layer_speed,
			SettingsKey.number_of_first_layers,
			SettingsKey.recover_is_enabled,
			SettingsKey.recover_position_before_z_home,
			SettingsKey.auto_release_motors,
			SettingsKey.resume_gcode,
			SettingsKey.temperature,
			SettingsKey.enable_retractions,
			"z_homes_to_max",

			// TODO: merge the items below into the list above after some validation - setting that weren't previously mapped to Cura but probably should be. 
			SettingsKey.bed_remove_part_temperature,
			"extruder_wipe_temperature",
			SettingsKey.heat_extruder_before_homing,
			SettingsKey.include_firmware_updater,
			SettingsKey.sla_printer,
			"layer_to_pause",
			SettingsKey.show_reset_connection,
			SettingsKey.validate_layer_height,
			SettingsKey.make,
			SettingsKey.model,
			SettingsKey.enable_network_printing,
			SettingsKey.enable_sailfish_communication,
			SettingsKey.max_velocity,
			SettingsKey.jerk_velocity,
			SettingsKey.max_acceleration,
			SettingsKey.ip_address,
			SettingsKey.ip_port,

		};

		public SliceEngineMapping(string engineName)
	{
			this.Name = engineName;
		}

		public string Name { get; }

		public abstract bool MapContains(string canonicalSettingsName);
	}
}